using Calculator.Data.Repos.BO;
using Calculator.Data.Repos.Model;
using Calculator.OperationsManager.Interfaces;
using System;

namespace Calculator.OperationsManager.BO
{
  public class InsertOperations : IOperationDb<bool, OperationValues>
  {
    public InsertOperations()
    {

    }
    public bool Manage(OperationValues values )
    {

      try
      {
        using (var db = new UnitOfWorkForCalculatorDb(null))
        {
          db.OperationsRepository.Add(values);

          return db.OperationsRepository.Commit() > 0;
         
        }
      }
      catch (Exception e)
      {

        return false;
      }

    }

  }
}
