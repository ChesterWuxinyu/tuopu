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
        public DataSet QueryFunctions(int pageIndex, int pageSize, out int rowCount, string pFuncName, string funcName, string level)
        {
            string strSql = @" SELECT  c.oid ,
                                    p.functionname AS PFucnName ,
                                    c.functionname AS funcName ,
                                    c.functionlevel ,
                                    c.functionstatus ,
                                    c.functionurl ,
                                    c.memo
                            FROM    dbo.TBLFUNCTION c
                                    LEFT JOIN dbo.TBLFUNCTION p ON c.functionparentid = p.oid
                            WHERE   1 = 1 ";
            if (!string.IsNullOrEmpty(pFuncName))
            {
                strSql += " and p.functionname like @PFuncName ";
            }
            if (!string.IsNullOrEmpty(funcName))
            {
                strSql += " and c.functionname like @FuncName ";
            }
            if (!string.IsNullOrEmpty(level))
            {
                strSql += " and c.functionlevel = @FuncLevel ";
            }
            string[] paramNames = new string[3];
            object[] paramValues = new object[3];

            paramNames[0] = "PFuncName";
            paramNames[1] = "FuncName";
            paramNames[2] = "FuncLevel";

            paramValues[0] = "%" + pFuncName + "%";
            paramValues[1] = "%" + funcName + "%";
            paramValues[2] = level;
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.QueryPageFromSql(strSql, paramNames, paramValues, pageIndex, pageSize, out rowCount);
            broker.Close();
            return dst;
        }

        public DataSet GetAllFunctions()
        {
            string strSql = " SELECT * FROM TBLFUNCTION ";
            SqlDBBroker broker = new SqlDBBroker();
            broker.Open();
            DataSet dst = broker.ExecuteDataset(strSql);
            broker.Close();
            return dst;
        }
    }
}
