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
        public void readCSVandShow(DataGridView dv)
        {
            string file_path = getFilePath();
            if (file_path.Length > 0)
            {
                StreamReader sr = new StreamReader(file_path);
                CSVParser scvP = new CSVParser();
                scvP.parsing(sr);
                DGVController.SetColumn(dv, scvP.getColumns());
                DGVController.SetRow(dv, scvP.getRows());
                sr.Close();
            }
        }
    }
}
