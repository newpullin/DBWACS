using DBWACS.Controller;
using DBWACS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public Form1()
        {
            InitializeComponent();
            InitializeController();
        }

        // 텍스트 박스에 있는 SQL을 실행합니다.
        private void btGo_Click(object sender, EventArgs e)
        {
            InputController.go(tbInput, dataGridView, sqlC, dgvC, fileC, mmb);
            
        }

        // DB를 열어서 내용을 표시합니다.
        private void mnu_DBOPEN_Click(object sender, EventArgs e)
        {
            string file_path = fileC.getFilePath("DB 파일 (*.mdf)|*.mdf");
            sqlC.setConnString(file_path);
            if(sqlC.Open(mmb))
            {
                stsC.setSuccessStatus("DB Opend", 1);
                InputController.setPath(tbPATH, file_path);
                InputController.setComboBox(cbTable, sqlC.getTables());
                fileC.readDBandSHow(dataGridView, sqlC, dgvC, InputController.getSelectedTable(cbTable));
            }
            else
            {
                stsC.setWarningStatus("DB Open Failed", 1);
            }
        }

        //DB를 닫습니다.
        private void mnu_DBCLOSE_Click(object sender, EventArgs e)
        {
            if(sqlC.Close(mmb))
            {
                stsC.setNomalStatus("DB Closed", 1);
                InputController.setPath(tbPATH, "");
                cbTable.Items.Clear();
            }
            else
            {
                stsC.setWarningStatus("DB Close Failed", 1);
            }
        }

        // CSV 파일을 열어서 내용을 표시합니다.
        private void mnu_CSVOPEN_Click(object sender, EventArgs e)
        {
            String result = fileC.readCSVandShow(dataGridView, dgvC);
            if(result == "")
            {
                stsC.setWarningStatus("CSV Open Failed...", 1);
            }
            else
            {
                tbPATH.Text = result;
                stsC.setSuccessStatus("CSV opened!", 1);
            }

        }
        // table 선택이 바뀌면 그 테이블에 대한 내용을 출력합니다.
        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileC.readDBandSHow(dataGridView, sqlC, dgvC, InputController.getSelectedTable(cbTable));
        }
    }
}
