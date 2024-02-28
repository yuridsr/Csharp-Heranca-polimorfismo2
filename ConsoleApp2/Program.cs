using ConsoleApp2.Entities;
using System.Globalization;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> listOfProduct = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #{0} data:", i);

                Console.Write("Common, used or imported(c / u / i) ? ");
                string ver = Console.ReadLine();

                while (ver != "C" && ver != "c" && ver != "U" && ver != "u" && ver != "I" && ver != "i")
                {
                    Console.WriteLine("Report only c / u / i: ");
                    Console.WriteLine();
                    Console.Write("Common, used or imported(c / u / i) ? ");
                    ver = Console.ReadLine();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ver == "c" || ver == "C")
                {
                    listOfProduct.Add(new Product(name, price));
                }
                else if (ver == "u" || ver == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listOfProduct.Add(new UsedProduct(name, price, date));
                }
                else if (ver == "i" || ver == "I")
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfProduct.Add(new ImportedProduct(name, price, fee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product Product in listOfProduct)
            {
                Console.WriteLine(Product.priceTag());
            }
        }
    }
}