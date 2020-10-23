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
                if (sConn.State == ConnectionState.Open)
                {
                    sCmd.Connection = null;
                    sConn.Close();
                }
                sConn = new SqlConnection();
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
                sCmd.Connection = null;
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
            for (int i = 0; i < LEN; i++)
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

        public bool updateDB(String tableName, String colName, String value, String condition, MyMessageBox mmb = null)
        {
            String sql = $"Update {tableName} SET {colName} = '{value}' WHERE {condition}";
            sCmd.CommandText = sql;
            try
            {
                sCmd.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                if (mmb != null)
                {
                    mmb.Show(e1.Message);
                }
                return false;
            }


            return true;
        }

        public bool insertDB(String tableName, String[] rows, MyMessageBox mmb = null)
        {
            String sql = $"INSERT {tableName} VALUES(" + String.Join(",", rows) + ");";
            sCmd.CommandText = sql;

            try
            {
                sCmd.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                if (mmb != null)
                {
                    mmb.Show(e1.Message);
                }
                return false;
            }

            return true;
        }
        public String[] getIDs(String table_name)
        {
            String sql = "SELECT id FROM " + table_name;
            sCmd.CommandText = sql;
            SqlDataReader sr = sCmd.ExecuteReader();
            List<String> result_list = new List<String>();
            while (sr.Read())
            {
                result_list.Add(sr.GetValue(0).ToString());
            }
            // 사용후 닫음
            sr.Close();
            return result_list.ToArray();
        }
        public String assumeTableName(String[] columns)
        {
            if(columns.Length < 2)
            {
                return "";
            }
            String[] tables = getTables();
            // 모든 테이블에 대해서
            for(int i = 0; i < tables.Length; i++)
            {
                int value = 0;
                // 테이블의 컬럼들을 구하고
                String[] table_columns = getHeader(tables[i]);
                // 주어진 컬럼들이 테이블의 컬럼들과 모두 일치하는 지확인
                bool allSame = true;
                foreach (String col in columns)
                {
                    bool finded = false;
                    for(int k = 0; k < table_columns.Length; k++)
                    {
                        if(col == table_columns[k])
                        {
                            finded = true;
                            break;
                        }
                    }
                    // 하나라도 일치 하지 않는게 있다면 다음 테이블 탐색
                    if (!finded)
                    {
                        allSame = false;
                        break;
                    }
                }
                //모두 같은게 있다면 그 테이블 이름 반환(모두 같은게 여러개일 수 있는 상황은 일단 무시)
                if(allSame)
                {
                    return tables[i];
                }

            }
            // 일치하는게 없으면
            return "";
        }
    }
}