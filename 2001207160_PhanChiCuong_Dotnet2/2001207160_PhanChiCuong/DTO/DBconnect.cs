using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DTO
{
    public class DBconnect
    {
        SqlConnection connect;

        string strSeverName, strConnect, strDataBaseName, strUserName, strPassword;

        public string StrConnect
        {
            get { return strConnect; }
            set { strConnect = value; }
        }

        public string StrSeverName
        {
            get { return strSeverName; }
            set { strSeverName = value; }
        }

        public string StrPassword
        {
          get { return strPassword; }
          set { strPassword = value; }
        }

        public string StrUserName
        {
          get { return strUserName; }
          set { strUserName = value; }
        }

        public string StrDataBaseName
        {
          get { return strDataBaseName; }
          set { strDataBaseName = value; }
        }

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        
      

        public DBconnect()
        {
            StrSeverName = @"A101GV";
            StrDataBaseName = "QLSINHVIEN";
            StrUserName = "sa";
            StrPassword = "123";
            StrConnect = @"Data Source" + strSeverName + ";Initial Catalog=" + strDataBaseName;
            StrConnect += ";User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection(StrConnect);
        }

        public DBconnect(string strSeverName, string strConnect, string strDataBaseName, string strUserName, string strPassword)
        {
            StrSeverName = strSeverName;
            StrDataBaseName = strDataBaseName;
            StrUserName = strUserName;
            StrPassword = strPassword;
            StrConnect = @"Data Source" + strSeverName + ";Initial Catalog=" + strDataBaseName;
            StrConnect += ";User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection(StrConnect);
        }

        public void openConnection()
        {
            if (connect.State.ToString() == "Closed")
                connect.Open();
        }
        public void closedConnection()
        {
            if (connect.State.ToString() == "Open")
                connect.Close();
        }
        public int executleNonQuery(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(sql, connect);
            int count = cmd.ExecuteNonQuery();
            closedConnection();
            return count;
        }

      
    }
}
