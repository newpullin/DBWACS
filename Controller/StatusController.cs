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
        public void setWarningStatus(string msg, int num)
        {
            setStatus(msg, getWarningColor(), getWhiteColor(), num);
        }
        public void setSuccessStatus(string msg, int num)
        {
            setStatus(msg, getSuccessColor(), getWhiteColor(), num);
        }
        public void setNomalStatus(string msg, int num)
        {
            setStatus(msg, Color.Empty, getBlackColor(), num);
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
