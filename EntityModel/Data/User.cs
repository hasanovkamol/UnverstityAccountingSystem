using EntityModel.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModel.Data
{
    public class User:DataModel
    {
        private int m_UserId;
        private string m_Password;
        private string m_Login;
        private Roll m_UserRoll;
        private string m_UserName;

        public int UserId { get=>GetValue(nameof(UserId),m_UserId); set=>SetValue(nameof(UserId),ref m_UserId,value); }
        public string UserName { get => GetValue(nameof(UserName), m_UserName); set => SetValue(nameof(UserName), ref m_UserName, value); }
        public Roll UserRoll { get => GetValue(nameof(UserRoll), m_UserRoll); set => SetValue(nameof(UserRoll), ref m_UserRoll, value); }
        public string Login { get => GetValue(nameof(Login), m_Login); set => SetValue(nameof(Login), ref m_Login, value); }
        public string Password { get => GetValue(nameof(Password), m_Password); set => SetValue(nameof(Password), ref m_Password, value); }
        public override void ApplyChanges()
        {
            base.ApplyChanges();
        }
    }
}
