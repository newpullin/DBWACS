using DBWACS.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS
{
    class SQLController
    {
        private SqlConnection sConn;
        private SqlCommand sCmd;
        private string connString;
        private StatusController sc;
        private string file_path;

        public SQLController()
        {
            sConn = new SqlConnection();
            sCmd = new SqlCommand();
            connString = "";
            file_path = "";
        }
        public SQLController(string file_path)
        {
            this.file_path = file_path;
            sConn = new SqlConnection();
            sCmd = new SqlCommand();
            connString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={file_path};Integrated Security=True;Connect Timeout=30";
        }

        public void setConnString(string file_path)
        {
            this.file_path = file_path;
            connString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={file_path};Integrated Security=True;Connect Timeout=30";
        }

        public Boolean Open(MyMessageBox mb = null)
        {
            try
            {
                if(sConn.State == ConnectionState.Open)
                {
                    Close();
                }
                sConn.ConnectionString = connString;
                sConn.Open();
                sCmd.Connection = sConn;
                return true;
            }
            catch (Exception e1)
            {
                if (mb != null)
                {
                    mb.Show(e1.Message);
                }
                return false;
            }
        }
        public Boolean Close(MyMessageBox mb = null)
        {
            try
            {
                sConn.Close();
                return true;
                
            }
            catch (Exception e1)
            {
                if (mb != null)
                {
                    mb.Show(e1.Message);
                }
                return false;
            }
        }
        public String[] getTables()
        {
            DataTable dt = sConn.GetSchema("tables");
            int LEN = dt.Rows.Count;
            String[] columns = new String[LEN];
            for(int i = 0; i < LEN; i++)
            {
                columns[i] = dt.Rows[i].ItemArray[2].ToString();
            }
            return columns;
        }
        
        public String[] getHeader(String tableName)
        {
            sCmd.CommandText = $"SELECT TOP 1 * FROM {tableName}";
            SqlDataReader sr = sCmd.ExecuteReader();
            String[] columns = new String[sr.FieldCount];
            for (int j = 0; j < sr.FieldCount; j++)
            {
                columns[j] = sr.GetName(j);
            }
            sr.Close();
            return columns;
        }
        public String[] getHeader(SqlDataReader sr)
        {
            String[] columns = new String[sr.FieldCount];
            for (int j = 0; j < sr.FieldCount; j++)
            {
                columns[j] = sr.GetName(j);
            }
            return columns;
        }
        public List<List<String>> getRows(String tableName)
        {
            sCmd.CommandText = $"SELECT * FROM {tableName}";
            SqlDataReader sr = sCmd.ExecuteReader();
            List<List<String>> rows = new List<List<String>>();
            int index = 0;
            while (sr.Read())
            {
                List<String> temp = new List<String>();
                rows.Add(temp);
                for (int j = 0; j < sr.FieldCount; j++)
                {
                    rows[index].Add(sr.GetValue(j).ToString());
                }
                index++;
            }
            // 사용후 닫음
            sr.Close();
            return rows;
        }
        public List<List<String>> getRows(SqlDataReader sr)
        {
            List<List<String>> rows = new List<List<String>>();
            int index = 0;
            while (sr.Read())
            {
                List<String> temp = new List<String>();
                rows.Add(temp);
                for (int j = 0; j < sr.FieldCount; j++)
                {
                    rows[index].Add(sr.GetValue(j).ToString());
                }
                index++;
            }
            // 빌려온거니까 닫으면 안됨
            return rows;
        }

        public SqlDataReader go(String sql)
        {
            sCmd.CommandText = sql;
            if (sql.ToUpper().Contains("SELECT"))
            {
                return sCmd.ExecuteReader();
            }
            else
            {
                sCmd.ExecuteNonQuery();
                return null;
            }
        }
    }
}