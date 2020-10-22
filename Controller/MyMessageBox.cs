using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS.Controller
{
    class MyMessageBox
    {
        private bool print;
        public MyMessageBox(bool print = false)
        {
            this.print = print;
        }
        public void Show(string msg)
        {
            if (print)
            {
                MessageBox.Show(msg);
            }
        }
    }
}
