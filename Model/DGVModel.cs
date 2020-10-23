using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DBWACS.Model
{
    public class DGVModel
    {
        private List<String> columns;
        private List<List<String>> rows;

        public DGVModel()
        {
            columns = new List<string>();
            rows = new List<List<string>>();
        }
        public void setColumns(String[] col)
        {
            columns.Clear();
            for(int i = 0; i < col.Length; i++)
            {
                columns.Add(col[i]);
            }
        }
        public void setRows(String[][] row)
        {
            rows.Clear();
            int len1 = row.GetLength(0);
            
            for(int i = 0; i < len1; i++)
            {
                List<String> temp = new List<string>();
                rows.Add(temp);
                int len2 = row[i].GetLength(0);
                for (int k = 0; k < len2; k++)
                {
                    rows[i].Add(row[i][k]);
                }
            }
        }
        public void setRows(List<List<String>> rows)
        {
            this.rows.Clear();
            this.rows = rows;
        }
        public String[] getColumns()
        {
            String[] return_string = new String[columns.Count];
            for(int i = 0; i < columns.Count; i++)
            {
                return_string[i] = columns[i];
            }
            return return_string;
        }
        public String[][] getRows()
        {
            String[][] return_string = new String[rows.Count][];

            for(int i = 0; i < rows.Count; i++)
            {
                return_string[i] = new String[rows[i].Count];
                for(int k = 0; k < rows[i].Count; k++)
                {
                    return_string[i][k] = rows[i][k];
                }
            }
            return return_string;
        }
        public void addRow(String[] new_row)
        {
            List<String> temp = new List<string>();
            
            for (int k = 0; k < new_row.Length; k++)
            {
                temp.Add(new_row[k]);
            }

            rows.Add(temp);
        }

        public void delRow(int index)
        {
            rows.RemoveAt(index);
        }

        public int getColumnSize()
        {
            return columns.Count;
        }
    }
}
