using System;
namespace CSharp_FinalTest
{
    class Phone : Product
    {
        public Phone(int id, string name, double price) : base(id, name, price) { }

        public override double ComputeTax()
        {
            return ProductPrice * 0.1;
        }
    }
}

