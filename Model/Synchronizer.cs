using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS.Model
{
    class Synchronizer
    {
        string table_name;

        public void syncDGVWADGVM(DataGridView dv, DGVModel dm)
        {
            String[] dm_cols = dm.getColumns();
            String[][] dm_rows = dm.getRows();

            // 둘의 크기는 같다고 생각한다.

            for(int i = 0; i < dm_rows.Length;i++)
            {
                for(int k = 0; k < dm_cols.Length; k++)
                {
                    String temp = dv.Rows[i].Cells[k].Value.ToString();
                    if (dm_rows[i][k] != temp)
                    {
                        dm.setValueRow(i, k, temp);
                    }
                }
            }
        }

        public void syncDBWADGVM(SQLController sq, DGVModel dm)
        {
            String[] dm_cols = dm.getColumns();
            String[][] dm_rows = dm.getRows();
            if(dm_cols[0] != "id")
            {
                return;
            }
            String table_name = sq.assumeTableName(dm_cols);
            String[] ids = sq.getIDs(table_name);


        }
    }
}
