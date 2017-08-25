using Microsoft.AspNetCore.Mvc;
using Calculator.Operations.Interfaces;
using Calculator.Operations.DTO;
using System;
using Calculator.OperationsManager.Concrete;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Calculator.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Operation")]
    public class OperationController : Controller
    {
        private OperationFactory operationFactory;
        private IOperations<dynamic, dynamic, dynamic> operationManager;

        public OperationController(OperationFactory operationFactory)
        {
            this.operationFactory = operationFactory;
        }

        [HttpPost]
        [Route("sum")]
        public string Sum([FromBody]JObject json)
        {

            OperationInput<string> request = JsonConvert.DeserializeObject<OperationInput<string>>(json.ToString());
            operationManager = operationFactory.CreateOperationType(OperationTypeEnum.Sum);

            return Calculate(request, operationManager);
        }



        [HttpPost]
        [Route("sub")]
        public string Sub([FromBody]JObject json)
        {

            OperationInput<string> request = JsonConvert.DeserializeObject<OperationInput<string>>(json.ToString());
            operationManager = operationFactory.CreateOperationType(OperationTypeEnum.Sub);

            return Calculate(request, operationManager);
        }

        [HttpPost]
        [Route("multipy")]
        public string Multipy([FromBody]JObject json)
        {

            OperationInput<string> request = JsonConvert.DeserializeObject<OperationInput<string>>(json.ToString());
            operationManager = operationFactory.CreateOperationType(OperationTypeEnum.Mulply);

            return Calculate(request, operationManager);
        }
        [HttpPost]
        [Route("divide")]
        public string Divide([FromBody]JObject json)
        {
            OperationInput<string> request = JsonConvert.DeserializeObject<OperationInput<string>>(json.ToString());
            operationManager = operationFactory.CreateOperationType(OperationTypeEnum.Divide);

            return Calculate(request, operationManager);
        }

        private string Calculate(OperationInput<string> request, IOperations<dynamic, dynamic, dynamic> operationManager)
        {
            long num;
            decimal dcml;
            if (long.TryParse(request.Num1, out num))
            {
                var input = new OperationInput<long>() { Num1 = Convert.ToInt64(request.Num1), Num2 = Convert.ToInt64(request.Num2) };

                return Convert.ToString(this.operationManager.Manage(input.Num1, input.Num2));
            }
            else if (Decimal.TryParse(request.Num1, out dcml))
            {
                var input = new OperationInput<decimal>() { Num1 = Convert.ToDecimal(request.Num1), Num2 = Convert.ToDecimal(request.Num2) };
                return Convert.ToString(this.operationManager.Manage(input.Num1, input.Num2));
            }
            else
            {
                var input = new OperationInput<int>() { Num1 = Convert.ToInt32(request.Num1), Num2 = Convert.ToInt32(request.Num2) };
                return Convert.ToString(this.operationManager.Manage(input.Num1, input.Num2));
            }
            return operationManager.Manage(request.Num1, request.Num2);
        }


    }
}