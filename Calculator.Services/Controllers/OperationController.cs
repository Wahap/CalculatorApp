using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Operation")]
    public class OperationController : Controller
    {
        public OperationController()
        {

        }
    }
}