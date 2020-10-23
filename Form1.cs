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
            // 콤보박스에 테이블을 유추해서 바꿔줍니다.
            InputController.setComboBox(cbTable, sqlC.assumeTableName(dgvM.getColumns()));

            
        }

        // DB를 열어서 내용을 표시합니다.
        private void mnu_DBOPEN_Click(object sender, EventArgs e)
        {
            dataGridView.ReadOnly = false;
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
            dataGridView.ReadOnly = true;
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
            // DGVM을 지속적으로 업데이트 해준다.
            sync.syncDGVWADGVM(dataGridView, dgvM);
            sync.syncDBWADGVM(sqlC, dgvM);
        }

        // 행 추가
        private void tsmnuAddRow_Click(object sender, EventArgs e)
        {
            
            String[] temp = new String[dgvM.getColumnSize()];
            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = "";
            }
            dgvM.addRow(temp);
            dataGridView.Rows.Add();
            dgvC.Show(dataGridView, dgvM);
            stsC.setSuccessStatus("Row Added!", 3);
        }

        private void mnu_DBSave_Click(object sender, EventArgs e)
        {
            if(sqlC.getStatus() == ConnectionState.Open)
            {
                sync.syncDBWADGVM(sqlC, dgvM);
                stsC.setSuccessStatus("DB Saved!", 1);
            }
            else
            {
                mmb.Show("DB를 열어주세요.");
            }
        }

        //행 삭제
        private void tsmnuDelRow_Click(object sender, EventArgs e)
        {
            int index = dataGridView.SelectedCells[0].RowIndex;
            if(index != -1)
            {
                dataGridView.Rows.RemoveAt(index);
                String id = dgvM.getColumn(0)[index];
                dgvM.delRow(index);
                dgvC.Show(dataGridView, dgvM);
                String table_name = sqlC.assumeTableName(dgvM.getColumns());
                sqlC.delete(table_name, id);
                stsC.setSuccessStatus("Row deleted!", 3);
            }
            
        }


        //id 가 무조건 primary key라고 가정하고, id 있을 경우에만 업데이트가 가능하도록 한다.
        // primary key 찾아내는 방법을 잘 모르겠다.


    }
}
