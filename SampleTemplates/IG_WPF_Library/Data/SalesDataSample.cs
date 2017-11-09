using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG_WPF_Library
{
    public class SalesDataSample : ObservableCollection<Sale>
    {
        public SalesDataSample()
        {
            ObservableCollection<Sale> sales = SalesDataGenerator.GenerateSales(500);
            foreach (Sale sale in sales)
            {
                this.Add(sale);
            }
        }
    }
    public class Sale
    {
        public Sale()
        {
            this.Product = new Product();
            this.Seller = new Seller();
        }
        public Product Product { get; set; }
        public Seller Seller { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public string Quarter { get; set; }
        public string City
        {
            get { return Seller.City; }
            set { Seller.City = value; }
        }
        public int NumberOfUnits { get; set; }
        public double AmountOfSale
        {
            get { return UnitPrice * NumberOfUnits; }
            set { Product.UnitPrice = value / NumberOfUnits; }
        }
        public double UnitPrice
        {
            get { return Product.UnitPrice; }
            set { Product.UnitPrice = value; }
        }
    }
    public class Seller
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Product
    {
        public Product() { }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
    public class SalesDataGenerator
    {
        private static String[] _products;
        private static String[] _sellerNames;
        private static String[] _cities;
        private static readonly Random Random = new Random();
        public static ObservableCollection<Sale> GenerateSales(int numberOfSales)
        {
            _products = "Accessories;Bikes;Clothing;Components".Split(';');
            _sellerNames = "John Smith;Alfredo Fetuchini;Howard Sprouse;Russell Shorter;Nicholas Carmona;Larry Lieb;Carl Costello;Benjamin Dupree;Bryan Culver;Monica Freitag;Lydia Burson;Harold Garvin;Walter Pang;David Haley;Glenn Landeros;Harry Tyler;Stanley Brooker;Antonio Charbonneau;Brandon Mckim;Claudia Kobayashi;Benjamin Meekins;Mark Slater;Kathe Pettel;Elisa Longbottom".Split(';');
            _cities = "Sofia;London;New York;Berlin;Seattle;Mellvile;Tokyo".Split(';');
            ObservableCollection<Sale> sales = new ObservableCollection<Sale>();
            for (double i = 0; i < numberOfSales; i++)
            {
                Sale sale = new Sale
                {
                    Quarter = "Q " + i,
                    Value = GetRandomPrice(),
                    Date = GetRandomDate(),
                    Product = GerRandomProduct(),
                    NumberOfUnits = GetRandomNumUnits(),
                    Seller = GetRandomSeller()
                };
                sales.Add(sale);
            }
            return sales;
        }
        #region Get Random Objects
        private static Seller GetRandomSeller()
        {
            return new Seller
            {
                City = GetRandomCity(),
                Name = GetRandomSellerName()
            };
        }
        private static string GetRandomSellerName()
        {
            Random a = new Random(Random.Next());
            return _sellerNames[a.Next(_sellerNames.Length)];
        }
        private static string GetRandomCity()
        {
            Random a = new Random(Random.Next());
            return _cities[a.Next(_cities.Length)];
        }
        private static int GetRandomNumUnits()
        {
            Random a = new Random(Random.Next());
            return a.Next(1, 500);
        }
        private static Product GerRandomProduct()
        {
            return new Product
            {
                Name = GetRandomProductName(),
                UnitPrice = GetRandomPrice()
            };
        }
        private static double GetRandomPrice()
        {
            Random a = new Random(Random.Next());
            return a.NextDouble() * 100;
        }
        private static string GetRandomProductName()
        {
            Random a = new Random(Random.Next());
            return _products[a.Next(_products.Length)];
        }
        private static DateTime GetRandomDate()
        {
            Random a = new Random(Random.Next());
            int day = a.Next(1, 28);
            int month = a.Next(1, 12);
            int year = a.Next(DateTime.Today.Year - 5, DateTime.Today.Year + 1);
            return new DateTime(year, month, day);
        }
        #endregion
    }
}
