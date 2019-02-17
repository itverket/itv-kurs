﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.E1_Naming
{
    public class Store
    {
        private List<Customer> CustomerList { get; set; } = new List<Customer>();

        public void AddUserToClientList(Customer customer)
        {
            CustomerList.Add(customer);
        }
    }
}

