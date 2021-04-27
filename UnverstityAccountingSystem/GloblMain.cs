using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnverstityAccountingSystem.AllWindows;

namespace UnverstityAccountingSystem
{
   public static class GloblMain
    {
        public static int BankCurrentId { get; set; }
        private static  Control usercontrol { get; set; }
        public static void showControl(Control control, Control Content)
        {
            usercontrol = Content;
            Content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);

        }
       
        
    }
}
