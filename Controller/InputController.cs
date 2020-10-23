using System;
using System.Collections.Generic;
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
    }
}
