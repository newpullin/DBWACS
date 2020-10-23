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
            int result = InputController.go(tbInput, dataGridView, sqlC, dgvC,dgvM ,fileC, mmb);
            int status_num = 2;
            if(result == 0)
            {
                stsC.setSuccessStatus("SELECT 문이 수행되었습니다.", status_num);
            }
            else if ( result == 1)
            {
                fileC.readDBandSHow(dataGridView, sqlC, dgvM, dgvC, InputController.getSelectedTable(cbTable));
                stsC.setSuccessStatus("쿼리문이 수행되었습니다.", status_num);
            }
            else if (result == -1)
            {
                stsC.setWarningStatus("쿼리에 오류가 있습니다.", status_num);
            }
            InputController.setComboBox(cbTable, sqlC.assumeTableName(dgvM.getColumns()));
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
                fileC.readDBandSHow(dataGridView, sqlC, dgvM, dgvC, InputController.getSelectedTable(cbTable));
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
            String result = fileC.readCSVandShow(dataGridView, dgvC, dgvM);
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
            fileC.readDBandSHow(dataGridView, sqlC, dgvM, dgvC, InputController.getSelectedTable(cbTable));
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 편집이 끝난 열에 대한 업데이트를 수행한다.
            // 인덱스가 벗어난 경우, 벗어날 수가 없지 행추할 때 추가할건데
        }

        private void tsmnuAddRow_Click(object sender, EventArgs e)
        {
            //그냥 Model이랑 Controller랑 분리 시켜놨어야 하는데, 괜히 붙여서 생고생 하는구나
            dgvM.addRow(new String[dgvM.getColumnSize()]);
            dgvC.Show(dataGridView, dgvM);
        }
        // 행 추가, 행 삭제

    }
}
