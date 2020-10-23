using DBWACS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS.Controller
{
    class InputController
    {
        public static void setComboBox(ComboBox cb, String[] cols)
        {
            cb.Items.Clear();
            foreach(String col in cols)
            {
                cb.Items.Add(col);
            }
            if(cb.Items.Count >0)
            {
                cb.SelectedIndex = 0;
            }
        }
        public static void setComboBox(ComboBox cb, String tableName)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                if (tableName == cb.Items[i].ToString())
                {
                    cb.SelectedIndex = i;
                    break;
                }
            }
        }
        public static string getSelectedTable(ComboBox cb)
        {
            return cb.SelectedItem.ToString();
        }

        public static void setPath(TextBox tb, String path)
        {
            tb.Text = path;
        }

        public static int go(TextBox tbInput, DataGridView dataGridView ,SQLController sqlC, DGVController dgvC,DGVModel dgvM, FileController fileC, MyMessageBox mmb = null)
        {
            string sSql;
            if (tbInput.SelectedText.Length > 5)
            {
                sSql = tbInput.SelectedText;
            }
            else
            {
                sSql = tbInput.Text;
            }

            try
            {
                SqlDataReader sr = sqlC.go(sSql);

                if (sr != null)
                {
                    dgvM.setColumns(sqlC.getHeader(sr));
                    dgvM.setRows(sqlC.getRows(sr));
                    sr.Close();
                    dgvC.Show(dataGridView, dgvM);
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch(Exception e)
            {
                if(mmb != null)
                {
                    mmb.Show(e.Message);
                }
                return -1;
            }
        }
    }
}
