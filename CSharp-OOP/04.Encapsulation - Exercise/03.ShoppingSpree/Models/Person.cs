using System;
using System.Collections.Generic;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> productsBag;
        
        private Person()
        {
            productsBag = new List<Product>();
           
        }
        public Person(string name,decimal money)
            :this()
        {
            Name = name;
            Money = money;
        }
        public string Name
        {
            get
            {
                return name;

            }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionsMsgs.NameExceptionMsg);
                }
                name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return money;

            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionsMsgs.MoneyExceptionMsg);
                }
                money = value;
            }
        }

        public string BuyProduct(Product product)
        {
            decimal moneyLeft = money - product.Price;
            if(moneyLeft<0)
            {
                throw new InvalidOperationException(String.Format
                    (ExceptionsMsgs.NotMoreMoneyExceptionMsg,Name,product.Name));
            }
            Money = moneyLeft;
            productsBag.Add(product);

            return $"{this.Name} bought {product.Name}";
        }

        public override string ToString()
        {
            if(productsBag.Count==0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", productsBag)}";
        }
    }
}
