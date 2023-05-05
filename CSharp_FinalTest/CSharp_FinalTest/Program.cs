namespace CSharp_FinalTest;
class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[5];

        products[0] = new Book(1, "Life Of Pi", 50);
        products[1] = new Book(2, "The Godfather", 55);
        products[2] = new Book(3, "The Alchemist", 45);
        products[3] = new Phone(4, "Iphone 15 Pro Max", 3000);
        products[4] = new Phone(5, "Samsung Galaxy S25", 2500);

        double totalBookTax = 0;
        double totalPhoneTax = 0;

        foreach (Product p in products)
        {
            if (p is Book)
            {
                totalBookTax += p.ComputeTax();
            }
            else if (p is Phone)
            {
                totalPhoneTax += p.ComputeTax();
            }
        }

        Console.WriteLine("Total tax for books: " + totalBookTax);
        Console.WriteLine("Total tax for phones: " + totalPhoneTax);
        Console.ReadKey();
    }
}

