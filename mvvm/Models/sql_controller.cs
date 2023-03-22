using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Models
{
    public class sql_controller
    {
        private static string sqlLogin = @"Data Source=(localdb)\local_db; Integrated Security=true;";
        public static SqlConnection sql_conn = new SqlConnection(sqlLogin);

        // (Dis-)connect Methods
        public static void Connect()
        {
            sql_conn.Open();
        }

        public static void Disconnect()
        {
            sql_conn.Close();
        }

    }
}
