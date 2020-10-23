using DBWACS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS
{
    public class DGVController
    {
        DGVModel dvData;

        public DGVController()
        {
            dvData = new DGVModel();
        }
        public void SetColumn(String[] columns)
        {
            dvData.setColumns(columns);
        }
        public void SetRow(String[][] rows)
        {
            dvData.setRows(rows);  
        }
        public void SetRow(List<List<String>> rows)
        {
            dvData.setRows(rows);
        }
        public void Show(DataGridView dv)
        {
            dv.Columns.Clear();
            String[] columns = dvData.getColumns();
            for (int i = 0; i < columns.Length; i++)
            {
                dv.Columns.Add(columns[i], columns[i]);
            }

            dv.Rows.Clear();
            String[][] rows = dvData.getRows();
            for (int i = 0; i < rows.GetLength(0); i++)
            {
                dv.Rows.Add(rows[i]);
            }
        }
    }
}
