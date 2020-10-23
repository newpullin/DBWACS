using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS
{
    public partial class Form2 : Form
    {
        private String return_string;
        public Form2()
        {
            InitializeComponent();
            return_string = "";
        }


        public string getString()
        {
            return return_string;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                return_string = textBox1.Text;
                this.Close();
            }
        }
    }
}
