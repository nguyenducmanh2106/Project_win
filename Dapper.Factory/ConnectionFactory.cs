using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

/*
 * create by Mao Qingyu 
 */

namespace Dapper.Factory
{
    /// <summary>
    /// Connection工厂用于实例化对应的IDbConnection对象，传递给Dapper。
    /// </summary>
    public class ConnectionFactory
    {
        private static readonly string connectionName = ConfigurationManager.AppSettings["ConnectionName"];
        private static readonly string connStringMySQL = ConfigurationManager.ConnectionStrings["DatabaseMySQL"].ConnectionString;
        private static readonly string connStringSQLServer = ConfigurationManager.ConnectionStrings["DatabaseSQLServer"].ConnectionString;

        public static IDbConnection CreateConnection()
        {
            IDbConnection conn = null;
            switch (connectionName)
            {
                case "SQLServer":
                    conn = new SqlConnection(connStringSQLServer);
                    break;
                case "MySQL":
                    conn = new MySqlConnection(connStringMySQL);
                    break;
                default:
                    conn = new SqlConnection(connStringSQLServer);
                    break;
            }
            conn.Open();
            return conn;
        }

    }
}
