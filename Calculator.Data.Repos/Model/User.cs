using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Data.Repos.Model
{ 
    [Table("tblUser")]
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsValid { get; set; }
      //  public Guid UID { get; set; }
    }


}
