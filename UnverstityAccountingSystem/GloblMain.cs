using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnverstityAccountingSystem.AllWindows;
using UnverstityAccountingSystem.Data;
using UnverstityAccountingSystem.Static;

namespace UnverstityAccountingSystem
{
   public static class GloblMain
    {
        public static DbContextEntity dbo=new DbContextEntity();
        public static int CurrentId { get; set; }
        public static Bank bank { get; set; }
        public static UnverstityAccountingSystem.Data.BankAccount bankaccount { get; set; }
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
       
        public static Roll ConvertFromEnumIntoString(string value)
        {
            switch (value)
            {
                case "Admin": return Roll.Admin;
                case "Adutor": return Roll.Adutor;
                default:
                    return Roll.Accountant;
            }
        }
        
        public static User SingIn(string login,string password)
        {
            var _user = dbo.Users.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
            return _user;
        }
    
    }
}
