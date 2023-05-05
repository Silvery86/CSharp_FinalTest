using System;
namespace CSharp_FinalTest
{
    class Book : Product
    {
        public Book(int id, string name, double price) : base(id, name, price) { }

        public override double ComputeTax()
        {
            return ProductPrice * 0.05;
        }
    }
}

