using DBWACS.Controller;
using System;
using System.Collections.Generic;
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

        public void Open(StatusController sc = null, MyMessageBox mb = null)
        {
            try
            {
                sConn.ConnectionString = connString;
                sConn.Open();
                sCmd.Connection = sConn;
            }
            catch(Exception e1)
            {
                if(mb != null)
                {
                    mb.Show(e1.Message);
                }
                if(sc != null)
                {
                    sc.setWarningStatus("DB Open Failed", 1);
                }
            }
        }
        public void Close(StatusController sc = null, MyMessageBox mb = null)
        {
            try
            {
                sConn.Close();
                sc.setNomalStatus("DB Closed", 1);
            }
            catch (Exception e1)
            {
                if (mb != null)
                {
                    mb.Show(e1.Message);
                }
                if (sc != null)
                {
                    sc.setWarningStatus("DB Close Failed", 1);
                }
            }
        }
    }
}
