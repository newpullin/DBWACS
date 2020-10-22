using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS
{
    class DGVController
    {
        
        public static void SetColumn(DataGridView dv, String[] columns)
        {
            dv.Columns.Clear();
            for(int i = 0; i < columns.Length; i++)
            {
                dv.Columns.Add(columns[i], columns[i]);
            }
        }
        public static void SetRow(DataGridView dv, string[][] rows)
        {
            dv.Rows.Clear();
            for(int i = 0; i < rows.GetLength(0); i++)
            {
                dv.Rows.Add(rows[i]);
            }
        }
    }
}
