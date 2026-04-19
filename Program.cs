using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductManagement {
    public class Product {
        private string name;
        private string category;
        private double price;
        private DateTime productDate;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Category {
            get { return category; }
            set { category = value; }
        }
    } 
} 