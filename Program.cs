using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductManagement
{
    public class Product
    {
        private string name;
        private string category;
        private double price;
        private DateTime productDate;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime ProductDate
        {
            get { return productDate; }
            set { productDate = value; }
        }
        public Product(string name, string category, double price, DateTime date) {
            Name = name;
            Category = category;
            Price = price;
            ProductDate = date;
        }
        public void GetData() {
            Console.WriteLine($"Mehsul: {Name} | Kateqoriya : {Category} | Qiymet: {Price} | Tarix: {ProductDate.ToShortDateString()}");
        }

        public bool IsOld() {
            return DateTime.Now > ProductDate;
        }
    } 