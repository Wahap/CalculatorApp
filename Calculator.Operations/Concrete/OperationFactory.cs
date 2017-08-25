using Calculator.Operations.DTO;
using Calculator.Operations.Interfaces;
using Calculator.OperationsManager.BO;

namespace Calculator.OperationsManager.Concrete
{
    public abstract class OperationFactory
    {
        public abstract IOperations<dynamic, dynamic, dynamic> CreateOperationType(OperationTypeEnum type);
    }


    public class ConcreteOperationType : OperationFactory
    {
        public override IOperations<dynamic, dynamic, dynamic> CreateOperationType(OperationTypeEnum type)
        {
            switch (type)
            {
                case OperationTypeEnum.Sum:
                  return  new SumOperation<dynamic>();
                    break;
                case OperationTypeEnum.Sub:
                    return new SubOperation<dynamic>();
                    break;
                case OperationTypeEnum.Mulply:
                    return new MultiplyOperation<dynamic>();
                    break;
                case OperationTypeEnum.Divide:
                    return new DivideOperation<dynamic>();
                    break;
                default:
                    return new SumOperation<dynamic>();
                    break;
            }
         
        }

    }
}
