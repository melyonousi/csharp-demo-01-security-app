using System.Data;
using System.Data.SqlClient;

namespace security_app
{
    static class Connection
    {
        private static string cs;
        private static SqlConnection cn;

        public static SqlConnection getConnection
        {
            get
            {
                openConnection();
                return cn;
            }
        }
        private static void openConnection()
        {
            cs = Properties.Settings.Default.EcoGuideSecConnectionString;
            cn = new SqlConnection(cs);

            if (cn.State != ConnectionState.Open)
                cn.Open();
        }


        public static void closeConnection()
        {
            cn = new SqlConnection();
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
                cn = null;
            }
        }
    }
}
