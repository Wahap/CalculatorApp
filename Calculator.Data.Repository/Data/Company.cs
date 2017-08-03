using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Data.Repository.Data
{

    [Table("tblCompany")]
    public partial class Company
    {

        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
    }
}
