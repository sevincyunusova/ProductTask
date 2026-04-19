using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductManagement{
    public class Product{
        private string name;
        private string category;
        private double price;
        private DateTime productDate;
        public string Name{
            get { return name; }
            set { name = value; }
        }
        public string Category{
            get { return category; }
            set { category = value; }
        }
        public double Price{
            get { return price; }
            set { price = value; }
        }
        public DateTime ProductDate{
            get { return productDate; }
            set { productDate = value; }
        }

        public Product(string name, string category, double price, DateTime date) {
            Name = name;
            Category = category;
            Price = price;
            ProductDate = date;
        }

        public void GetData(){
            Console.WriteLine($"Mehsul: {Name} | Kateqoriya : {Category} | Qiymet: {Price} | Tarix: {ProductDate.ToShortDateString()}");
        }

        public bool IsOld(){
            return DateTime.Now > ProductDate;
        }
    }

    class Program{
        static void Main(string[] args) {
            List<Product> products = new List<Product>();
            Product p1 = new Product("Süd", "Süd məhsulları", 2.50, new DateTime(2023, 01, 01));
            Product p2 = new Product("Qatıq", "Süd məhsulları", 2.80, new DateTime(2027, 01, 01));
            Product p3 = new Product("Çörək", "Un məmulatları", 0.65, new DateTime(2027, 05, 05));

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            if (products.Contains(p1)){
                Console.WriteLine($"{p1.Name} siyahıda var.");
            }


            Console.WriteLine("--- Süd məhsulları ---");
            var filtered = products.Where(p => p.Category == "Süd məhsulları").ToList();
            foreach (var item in filtered) item.GetData();

            products.RemoveAll(p => p.IsOld());
            Console.WriteLine("Köhnə məhsullar təmizləndi.");
            Console.WriteLine("--- Qalan Məhsullar ---");
            foreach (var item in products) item.GetData(); }
    } 
}