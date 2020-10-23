using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DBWACS.Model;

namespace DBWACS
{
    class FileController
    {
        public string getFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                return ofd.FileName;
            }
            return "";
        }
        public string getFilePath(string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                return ofd.FileName;
            }
            return "";
        }
        public string readCSVandShow(DataGridView dv, DGVController dc, DGVModel dm)
        {
            string file_path = getFilePath("CSV 파일 (*.csv)|*.csv");
            if (file_path.Length > 0)
            {
                try
                {
                    StreamReader sr = new StreamReader(file_path);
                    CSVParser scvP = new CSVParser();
                    scvP.parsing(sr);
                    dm.setColumns(scvP.getColumns());
                    dm.setRows(scvP.getRows());
                    dc.Show(dv, dm);
                    sr.Close();
                }
                catch(Exception e1)
                {
                    return "";
                }
            }

            return file_path;
        }

        public Boolean readDBandSHow(DataGridView dv, SQLController sc, DGVModel dm ,DGVController dc, String table_name)
        {
            try {
                dm.setColumns(sc.getHeader(table_name));
                dm.setRows(sc.getRows(table_name));
                dc.Show(dv, dm); 
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                
            }
            return true;
        }
    }
}
