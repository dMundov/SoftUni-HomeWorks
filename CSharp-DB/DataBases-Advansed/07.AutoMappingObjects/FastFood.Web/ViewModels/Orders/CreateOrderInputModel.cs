﻿namespace FastFood.Web.ViewModels.Orders
{
    using System.ComponentModel.DataAnnotations;

    public class CreateOrderInputModel
    {
        [Required]
        [MinLength(3), MaxLength(30)]
        public string Customer { get; set; }

        public string ItemName { get; set; }

        public string EmployeeName { get; set; }

        [Required][Range(1, 100)]
        public int Quantity { get; set; }
        [Required]
        public string OrderType { get; set; }
    }
}
