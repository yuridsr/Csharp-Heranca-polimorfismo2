using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public double totalPrice()
        {
            return CustomsFree + Price;
        }

        public sealed override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFree.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

    }
}
