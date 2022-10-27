using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionRuleSystem.Domain
{
    public class Customer
    {
        public Customer(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }

        public string Name { get; set; }
    
        public int Balance { get; set; }
    }
}
