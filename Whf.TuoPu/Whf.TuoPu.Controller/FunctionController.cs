using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Whf.TuoPu.DAL;

namespace Whf.TuoPu.Controller
{
    public class FunctionController
    {
        /// <summary>
        /// 查询功能列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="rowCount"></param>
        /// <param name="pFuncName"></param>
        /// <param name="funcName"></param>
        /// <param name="level"></param>
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
    }
}
