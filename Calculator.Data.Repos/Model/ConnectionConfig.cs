﻿using Calculator.Data.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Repos.Model
{
  public  class ConnectionConfig: IConnectionValue
    {
        public string CalculatorDbName { get; set; }
        public string ServerName { get; set; }
        public DateTime StartDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EndDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
