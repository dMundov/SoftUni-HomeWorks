﻿
namespace P03_SalesDatabase.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }

        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string CreditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; }




    }
}
