﻿using System;
using System.Globalization;

namespace Exercicio.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem()
        {

        }
        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;


        }

        public override string ToString()
        {

            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " , Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
