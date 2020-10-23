using DBWACS.Controller;
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

        private void InitializeController()
        {
            stsC = new StatusController(statusStrip1);
            sqlC = new SQLController();
            fileC = new FileController();
            //Message Box 출력을 활성화
            mmb = new MyMessageBox(true);
            dgvC = new DGVController();
        }
    }

    
}
