using DBWACS.Controller;
using DBWACS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS
{
    public partial class Form1 : Form
    {
        SQLController sqlC;
        StatusController stsC;
        MyMessageBox mmb;
        FileController fileC;
        
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            stsC = new StatusController(statusStrip1);
            sqlC = new SQLController("aaa");
            fileC = new FileController();
            //Message Box 출력을 활성화
            mmb = new MyMessageBox(true);
        }

        // 텍스트 박스에 있는 SQL을 실행합니다.
        private void btGo_Click(object sender, EventArgs e)
        {
            
        }

        private void mnu_DBOPEN_Click(object sender, EventArgs e)
        {
            sqlC.Open(stsC, mmb);
        }
        private void mnu_DBCLOSE_Click(object sender, EventArgs e)
        {
            sqlC.Close(stsC, mmb);
        }

        // CSV 파일을 열어서 내용을 표시합니다.
        private void mnu_CSVOPEN_Click(object sender, EventArgs e)
        {
            fileC.readCSVandShow(dataGridView);
        }

        
    }
}
