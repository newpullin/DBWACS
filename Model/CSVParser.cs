using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWACS.Model
{
    class CSVParser
    {
        private string[] columns;
        private string[][] rows;
        public void parsing(StreamReader sr, char separator = ',')
        {
            this.columns = sr.ReadLine().Split(separator);
            string[] lines = sr.ReadToEnd().Split(new char[] { '\n' });
            rows = new string[lines.Length][];
            for(int i = 0; i < lines.Length; i++)
            {
                rows[i] = lines[i].Split(separator);
            }
        }
        public string[] getColumns()
        {
            return this.columns;
        }
        public string[][] getRows()
        {
            return this.rows;
        }
    }
}
