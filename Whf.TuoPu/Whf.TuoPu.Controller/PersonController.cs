using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Whf.TuoPu.DAL;
using Whf.TuoPu.Entity;

namespace Whf.TuoPu.Controller
{
    public class PersonController
    {
        #region 查询
        public PersonEntity GetPersonInfo(string personID)
        {
            PersonEntity pe = new PersonEntity();
            string strSql = @" SELECT  *  
                                FROM    TBLPERSON where oid=@OID ";
            string[] paramName = new string[1];
            object[] paramValue = new object[1];
            paramName[0] = "OID";

            paramValue[0] = personID;
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.ExecuteDataset(strSql, CommandType.Text, paramName, paramValue);
            broker.Close();
            if (dst != null && dst.Tables[0] != null && dst.Tables[0].Rows.Count > 0)
            {
                return this.DataRow2Person(dst.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public PersonEntity GetPersonInfo(string userName, string passWord)
        {
            PersonEntity pe = new PersonEntity();
            string strSql = @" SELECT  * 
                                FROM    TBLPERSON where personaccount=@UserName and personpassword=@PassWord";
            string[] paramName=new string[2];
            object[] paramValue = new object[2];
            paramName[0]="UserName";
            paramName[1] = "PassWord";

            paramValue[0] = userName;
            paramValue[1] = passWord;
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.ExecuteDataset(strSql,CommandType.Text,paramName,paramValue);
            broker.Close();
            if (dst != null && dst.Tables[0] != null && dst.Tables[0].Rows.Count > 0)
            {
                return this.DataRow2Person(dst.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        private PersonEntity DataRow2Person(DataRow dr)
        {
            PersonEntity pe = new PersonEntity();
            if (dr != null)
            {
                pe.OID = Convert.ToString(dr["oid"]);
                pe.PERSONACCOUNT = Convert.ToString(dr["personaccount"]);
                pe.PERSONNAME = Convert.ToString(dr["personname"]);
                pe.PERSONSEX = Convert.ToInt32(dr["personsex"]);
                pe.PERSONSTATUS = Convert.ToInt32(dr["personstatus"]);
                pe.PERSONTYPE = Convert.ToInt32(dr["persontype"]);
                pe.PERSONEMAIL = Convert.ToString(dr["personemail"]);
                pe.PERSONMOBILEPHONE = Convert.ToString(dr["personmobilephone"]);
                pe.PERSONOFFICEPHONE = Convert.ToString(dr["personofficephone"]);
                pe.PERSONMEMO = Convert.ToString(dr["personmemo"]);
            }
            return pe;
        }

        public DataSet QueryPersons(int pageIndex,int pageSize,out int rowCount,string userAccount,string userName)
        {
            string strSql = @" SELECT  oid ,
                                        personaccount ,
                                        personname ,
                                        personsex ,
                                        personofficephone ,
                                        personmobilephone ,
                                        personemail ,
                                        personmemo
                                FROM    TBLPERSON where 1=1 ";
            if (!string.IsNullOrEmpty(userAccount))
            {
                strSql += " and personaccount like @PersonAccount ";
            }
            if (!string.IsNullOrEmpty(userName))
            {
                strSql += " and personname like @PersonName ";
            }
            string[] paramNames = new string[2];
            object[] paramValues = new object[2];

            paramNames[0] = "PersonAccount";
            paramNames[1] = "PersonName";

            paramValues[0] = "%" + userAccount + "%";
            paramValues[1] = "%" + userName + "%";
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.QueryPageFromSql(strSql,paramNames,paramValues,pageIndex,pageSize,out rowCount);
            broker.Close();
            return dst;
        }
        #endregion
    }
}
