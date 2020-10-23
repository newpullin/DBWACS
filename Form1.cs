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
            go();   
        }

        // DB를 열어서 내용을 표시합니다.
        private void mnu_DBOPEN_Click(object sender, EventArgs e)
        {
            openDB();
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
                stsC.setNomalStatus("", 2);
                stsC.setNomalStatus("", 3);
            }
            else
            {
                tbPATH.Text = result;
                stsC.setSuccessStatus("CSV opened!", 1, true);
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
            stsC.setNomalStatus("Change Saved!", 3);
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
            stsC.setSuccessStatus("Row Added!", 2);
            stsC.setNomalStatus("", 3);
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

        private void 테이블추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Location = new Point((int)(this.Width / 2) + this.Location.X, ((int)(this.Height / 2) + this.Location.Y));
            form2.ShowDialog();
            String result = form2.getString();
            if(result.Length > 0)
            {
                if(sqlC.createTable(result, mmb))
                {
                    stsC.setSuccessStatus("테이블 생성 성공!", 1, true);
                    // 새로 생성된 테이블로 바뀌는게 자연스러운듯
                    InputController.setComboBox(cbTable, sqlC.getTables());
                    InputController.setComboBoxIndex(cbTable, result);
                }
                else
                {
                    stsC.setWarningStatus("테이블 생성 실패!", 1, true);
                }
            }
        }

        private void 테이블삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Location = new Point((int)(this.Width / 2) + this.Location.X, ((int)(this.Height / 2) + this.Location.Y));
            form2.ShowDialog();
            String result = form2.getString();
            if (result.Length > 0)
            {
                if (sqlC.deleteTable(result, mmb))
                {
                    stsC.setSuccessStatus("테이블 삭제 성공!", 1, true);
                    // 새로 생성된 테이블로 바뀌는게 자연스러운듯
                    InputController.setComboBox(cbTable, sqlC.getTables());
                }
                else
                {
                    stsC.setWarningStatus("테이블 삭제 실패!", 1, true);
                }
            }
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Enter)
            {
                go();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.O)
            {
                openDB();
            }
        }


        //id 가 무조건 primary key라고 가정하고, id 있을 경우에만 업데이트가 가능하도록 한다.


    }
}
