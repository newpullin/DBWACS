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
            
            String table_name = sq.assumeTableName(dm_cols);
            String[] ids = sq.getIDs(table_name);
            DGVModel dgvM = new DGVModel();
            dgvM.setRows(sq.getRows(table_name));
            String[][] db_rows = dgvM.getRows();

            for (int i = 0; i < dm_rows.Length; i++)
            {
                String id = dm_rows[i][0];
                if (Array.IndexOf(ids, id) != -1)
                {
                    //아이디가 있고
                    // DB의 저장된 값이 현재 셀의 값과 다를 때  업데이트
                    for (int k = 1; k < dm_cols.Length; k++)
                    {
                        int index = -1;
                        for(int c = 0; c < dm_rows.Length; c++)
                        {
                            if(id == db_rows[c][0])
                            {
                                index = c;
                                break;
                            }
                        }
                        if(db_rows[index][k] != dm_rows[i][k])
                        {
                            sq.updateDB(table_name, dm_cols[k], dm_rows[i][k], $"id = {id}");
                        }
                    }
                }
                else
                {
                    //아이디가 없으면 삽입
                    sq.insertDB(table_name, dm_cols, dm_rows[i]);
                }
            }


        }
    }
}
