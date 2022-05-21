using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KETOANDOANHTHU
{
    class DAL
    {
        SqlConnection connection;
        string ketnoi = @"Data Source=SV-CAS-107;Initial Catalog=KETOANDOANHTHU;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ketnoi);
            return connection;
        }
        public DataTable GetDataTable(string sqlquery)
        {
            connection = getConnection();
            connection.Open();
            command = new SqlCommand(sqlquery,connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public void executeNonQuery(string sqlquery)
        {
            connection = getConnection();
            connection.Open();
            command = new SqlCommand(sqlquery, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            command.Clone();
           
        }
    }
}
