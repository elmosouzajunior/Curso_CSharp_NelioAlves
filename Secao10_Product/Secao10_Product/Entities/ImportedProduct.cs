using System;
using System.Text;
using System.Globalization;

namespace Secao10_Product.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override void PriceTag()
        {
            Console.WriteLine(
                "Name: "
                + Name
                + " $ "
                + (Price + CustomsFee).ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")"
                );
        }
    }
}
