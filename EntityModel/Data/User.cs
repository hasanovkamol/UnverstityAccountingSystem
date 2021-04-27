using EntityModel.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModel.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Roll UserRoll { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
    }
}
