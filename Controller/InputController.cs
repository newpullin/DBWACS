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
        public static string getSelectedTable(ComboBox cb)
        {
            return cb.SelectedItem.ToString();
        }

        public static void setPath(TextBox tb, String path)
        {
            tb.Text = path;
        }

        public static bool go(TextBox tbInput, DataGridView dataGridView ,SQLController sqlC, DGVController dgvC, FileController fileC, MyMessageBox mmb = null)
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
                    dgvC.SetColumn(sqlC.getHeader(sr));
                    dgvC.SetRow(sqlC.getRows(sr));
                    sr.Close();
                    dgvC.Show(dataGridView);
                }

                
            }
            catch(Exception e)
            {
                if(mmb != null)
                {
                    mmb.Show(e.Message);
                }
                return false;
            }
            return true;
        }
    }
}
