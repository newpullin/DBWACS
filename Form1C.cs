using DBWACS.Controller;
using DBWACS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS
{
    class Form1C
    {
    }
    public partial class Form1 : Form
    {
        SQLController sqlC;
        StatusController stsC;
        MyMessageBox mmb;
        FileController fileC;
        DGVController dgvC;
        DGVModel dgvM;
        Synchronizer sync;

        private void InitializeController()
        {
            stsC = new StatusController(statusStrip1);
            sqlC = new SQLController();
            fileC = new FileController();
            //Message Box 출력을 활성화
            mmb = new MyMessageBox(true);
            dgvC = new DGVController();
            dgvM = new DGVModel();
            sync = new Synchronizer();
        }

        private void go()
        {
            int result = InputController.go(tbInput, dataGridView, sqlC, dgvC, dgvM, fileC, mmb);
            int status_num = 2;
            if (result == 0)
            {
                stsC.setSuccessStatus("SELECT 문이 수행되었습니다.", status_num);
            }
            else if (result == 1)
            {
                fileC.readDBandSHow(dataGridView, sqlC, dgvM, dgvC, InputController.getSelectedTable(cbTable));
                stsC.setSuccessStatus("쿼리문이 수행되었습니다.", status_num);
            }
            else if (result == -1)
            {
                stsC.setWarningStatus("쿼리에 오류가 있습니다.", status_num);
            }
            // 콤보박스에 테이블을 유추해서 바꿔줍니다.
            InputController.setComboBoxIndex(cbTable, sqlC.assumeTableName(dgvM.getColumns()));
        }
        private void openDB()
        {
            dataGridView.ReadOnly = false;
            string file_path = fileC.getFilePath("DB 파일 (*.mdf)|*.mdf");
            sqlC.setConnString(file_path);
            if (sqlC.Open(mmb))
            {
                stsC.setSuccessStatus("DB Opend", 1, true);
                InputController.setPath(tbPATH, file_path);
                InputController.setComboBox(cbTable, sqlC.getTables());
                fileC.readDBandSHow(dataGridView, sqlC, dgvM, dgvC, InputController.getSelectedTable(cbTable));
            }
            else
            {
                stsC.setWarningStatus("DB Open Failed", 1);
            }
        }
    }

    
}
