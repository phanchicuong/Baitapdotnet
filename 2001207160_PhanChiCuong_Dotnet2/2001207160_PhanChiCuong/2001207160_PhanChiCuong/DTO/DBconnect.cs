using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
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


        private DataSet ds;

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
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

        
      public string StrConnection
        { }

        public DBconnect()
        {
            StrSeverName = @"A110PC40";
            StrDataBaseName = "QLSINHVIEN";
            StrUserName = "sa";
            StrPassword = "123";
            strConnect = @"Data Source" + strSeverName + ";Initial Catalog=" + strDataBaseName;
            strConnect += ";User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection(strConnect);
        }

        public DBconnect(string strSeverName, string strConnect, string strDataBaseName, string strUserName, string strPassword)
        {
            StrSeverName = strSeverName;
            StrDataBaseName = strDataBaseName;
            StrUserName = strUserName;
            StrPassword = strPassword;
            strConnect = @"Data Source" + strSeverName + ";Initial Catalog=" + strDataBaseName;
            strConnect += ";User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection(strConnect);
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
        
        //public DataTable getDataTable(string strSQL)
        //{
        //    SqlDataAdapter ada = new SqlDataAdapter(strSQL,Connect);
        //    ada.Fill(ds);
        //    return ds.Tables[0];
        //}
        public DataTable getDataTable(string strSQL, string tableName)
        {
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, Connect);
            ada.Fill(ds,tableName);
            return ds.Tables[tableName];
        }
        public SqlDataAdapter getDataAdapter(string strSQL, string tableName)
        {
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, Connect);
            ada.Fill(ds, tableName);
            return ada;
        }
    }
}
