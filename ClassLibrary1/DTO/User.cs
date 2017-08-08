using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.UserManager.DTO
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Guid UID { get; set; }
    }
}
