using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calculator.Data.Repos.Model
{

  [Table("tblOperations")]
  public partial class OperationValues
  {
    [Key]
    public int OperationID { get; set; }
    public string OperationName { get; set; }
    public string FirstValue { get; set; }
    public string SecondValue { get; set; }
  }
}
