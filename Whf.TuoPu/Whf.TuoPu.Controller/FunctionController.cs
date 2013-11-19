using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Whf.TuoPu.DAL;
using Whf.TuoPu.Entity;

namespace Whf.TuoPu.Controller
{
    public class FunctionController
    {
        #region 操作

        #endregion

        #region 查询
        public string GetChildMaxOrder(string oid)
        {
            string strSQL = @" SELECT COUNT(1)+1 FROM TBLFUNCTION WHERE functionparentid=@OID ";
            string[] paramNames = new string[1];
            object[] paramValues = new object[1];

            paramNames[0] = "OID";
            paramValues[0] = oid;
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            return broker.ExecuteScalar(strSQL, CommandType.Text, paramNames, paramValues);
        }

        public FunctionEntity GetFunc(string oid)
        {
            string strSQL = @" SELECT * FROM TBLFUNCTION WHERE oid=@OID ";
            string[] paramNames = new string[1];
            object[] paramValues = new object[1];

            paramNames[0] = "OID";
            paramValues[0] = oid;
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.ExecuteDataset(strSQL,CommandType.Text,paramNames,paramValues);
            broker.Close();
            if (dst != null && dst.Tables[0] != null && dst.Tables[0].Rows.Count > 0)
            {
                return Datarow2Entity(dst.Tables[0].Rows[0]);
            }
            else
            { return null; }
        }

        private FunctionEntity Datarow2Entity(DataRow dr)
        {
            if (dr != null)
            {
                FunctionEntity fun = new FunctionEntity();
                fun.OID = Convert.ToString(dr["OID"]);
                fun.FUNCTIONKEY = Convert.ToString(dr["FUNCTIONKEY"]);
                fun.FUNCTIONLEVEL = Convert.ToInt32(dr["FUNCTIONLEVEL"]);
                fun.FUNCTIONNAME = Convert.ToString(dr["FUNCTIONNAME"]);
                fun.FUNCTIONORDER = Convert.ToInt32(dr["FUNCTIONORDER"]);
                fun.FUNCTIONPARENTID = Convert.ToString(dr["FUNCTIONPARENTID"]);
                fun.FUNCTIONSTATUS = Convert.ToString(dr["FUNCTIONSTATUS"]);
                fun.FUNCTIONTYPE = Convert.ToInt32(dr["FUNCTIONTYPE"]);
                fun.FUNCTIONURL = Convert.ToString(dr["FUNCTIONURL"]);
                fun.MEMO = Convert.ToString(dr["MEMO"]);
                return fun;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 查询功能列表
        /// </summary>
        /// <param name="funcCode"></param>
        /// <param name="funcName"></param>
        /// <returns></returns>
        public DataSet QueryFunctions(string funcCode,string funcName)
        {
            string strSql = @" SELECT  *
                            FROM    dbo.TBLFUNCTION 
                            WHERE   1 = 1 ";
            if (!string.IsNullOrEmpty(funcCode))
            {
                strSql += " and p.functionkey = FunCode ";
            }
            if (!string.IsNullOrEmpty(funcName))
            {
                strSql += " and p.functionname = FunName ";
            }
            strSql += " ORDER BY functionorder ";
            string[] paramNames = new string[2];
            object[] paramValues = new object[2];

            paramNames[0] = "FunCode";
            paramNames[1] = "FunName";

            paramValues[0] = funcCode;
            paramValues[1] = funcName;
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.ExecuteDataset(strSql);
            broker.Close();
            return dst;
        }

        public DataSet GetAllFunctions()
        {
            string strSql = " SELECT * FROM TBLFUNCTION  ORDER BY functionorder ";
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.ExecuteDataset(strSql);
            broker.Close();
            return dst;
        }
        #endregion
    }
}
