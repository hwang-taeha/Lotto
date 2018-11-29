using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoQuiz
{
    class SqlServerConnect
    {
        private static SqlServerConnect sqlServer = new SqlServerConnect();
        private SqlServerConnect() { }
        private SqlConnection con;
        public static SqlServerConnect CreateSQL()
        {
            if (sqlServer == null)
            {
                sqlServer = new SqlServerConnect();
            }
            return sqlServer;
        }

        public SqlConnection ServerOpen(string conStr)
        {
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
            }
            catch (SqlException)
            {
                System.Windows.Forms.MessageBox.Show("연결실패");
            }

            return con;
        }

        public void ServerClose()
        {
            try
            {
                con.Close();
            }
            catch (SqlException)
            {

                System.Windows.Forms.MessageBox.Show("종료시 에러");
            }
        }

    }
}