using System;
namespace CSharp_FinalTest
{
    abstract class Product
    {
        private int productId;
        private string productName;
        private double productPrice;

        public Product(int id, string name, double price)
        {
            this.productId = id;
            this.productName = name;
            this.productPrice = price;
        }

        public int ProductId
        {
            get { return productId; }
        }

        public string ProductName
        {
            get { return productName; }
        }

        public double ProductPrice
        {
            get { return productPrice; }
        }

        public abstract double ComputeTax();
    }
}

