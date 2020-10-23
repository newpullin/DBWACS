using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWACS.Controller
{
    class StatusController
    {
        private StatusStrip myStrip;
        private Color white;
        private Color black;
        private const int MAX_MSG_LENGTH = 20;

        public StatusController(StatusStrip myStrip)
        {
            this.myStrip = myStrip;
        }
        public void setStatus(string msg, Color backColor, Color fontColor, int num=1)
        {
            if(num > myStrip.Items.Count)
            {
                return;
            }
            if(msg.Length > MAX_MSG_LENGTH)
            {
                msg = msg.Substring(0, MAX_MSG_LENGTH);
            }
            myStrip.Items[num - 1].Text = msg;
            myStrip.Items[num - 1].BackColor = backColor;
            myStrip.Items[num - 1].ForeColor = fontColor;
        }
        public void setStatus(string msg, Color backColor, Color fontColor, int num = 1, bool AllClose = false)
        {
            if (num > myStrip.Items.Count)
            {
                return;
            }
            if (msg.Length > MAX_MSG_LENGTH)
            {
                msg = msg.Substring(0, MAX_MSG_LENGTH);
            }
            for(int i = 0; i < myStrip.Items.Count-1; i++)
            {
                if(i == num - 1)
                {
                    myStrip.Items[i].Text = msg;
                    myStrip.Items[i].BackColor = backColor;
                    myStrip.Items[i].ForeColor = fontColor;
                }
                else
                {
                    myStrip.Items[i].Text = "";

                }
            }
            
        }
        public void setWarningStatus(string msg, int num, bool AllClose = false)
        {
            setStatus(msg, getWarningColor(), getWhiteColor(), num, AllClose);
        }
        public void setSuccessStatus(string msg, int num, bool AllClose = false)
        {
            setStatus(msg, getSuccessColor(), getWhiteColor(), num, AllClose);
        }
        public void setNomalStatus(string msg, int num, bool AllClose = false)
        {
            setStatus(msg, Color.Empty, getBlackColor(), num, AllClose);
        }
        public Color getWarningColor()
        {
            return Color.Red;
        }
        public Color getSuccessColor()
        {
            return Color.Green;
        }
        public Color getWhiteColor()
        {
            return Color.White;
        }
        public Color getBlackColor()
        {
            return Color.Black;
        }
    }
}
