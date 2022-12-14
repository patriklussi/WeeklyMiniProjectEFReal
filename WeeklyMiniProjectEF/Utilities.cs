using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMiniProjectEF
{
    internal class Utilities
    {
        public static double USDToSEKConversionRate = 10.32;
        public static double USDToEURConversionRate = 0.95;

        public static double CalculateCurrency(int purchasePrice, string currency)
        {
            if (currency == "SEK")
            {
                return purchasePrice * USDToSEKConversionRate;
            }
            else if (currency == "EUR")
            {
                return purchasePrice * USDToEURConversionRate;
            }
            else
            {
                return purchasePrice;
            }

        }
        public static void ResultPrinter(string AssetType, string Name, string Model, int PurchasePrice, DateTime PurchaseDate, string CurrencyType, string OfficeName)
        {
            DateTime CurrentDate = DateTime.Now;
            DateTime ExpiryDate = PurchaseDate.AddYears(3);

            if (ExpiryDate < CurrentDate.AddMonths(-3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(AssetType.PadRight(14)
               + Name.PadRight(14)
               + Model.PadRight(14)
               + OfficeName.PadRight(14)
               + PurchaseDate.ToShortDateString().PadRight(14)
               + PurchasePrice.ToString().PadRight(14)
               + CurrencyType.PadRight(14)
               + Utilities.CalculateCurrency(PurchasePrice, CurrencyType).ToString());
                Console.ResetColor();
            }
            else if (ExpiryDate < CurrentDate.AddMonths(-6))
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(AssetType.PadRight(14)
               + Name.PadRight(14)
               + Model.PadRight(14)
               + OfficeName.PadRight(14)
               + PurchaseDate.ToShortDateString().PadRight(14)
               + PurchasePrice.ToString().PadRight(14)
               + CurrencyType.PadRight(14)
               + Utilities.CalculateCurrency(PurchasePrice, CurrencyType).ToString());
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(AssetType.PadRight(14)
               + Name.PadRight(14)
                + Model.PadRight(14)
                  + OfficeName.PadRight(14)
                 + PurchaseDate.ToShortDateString().PadRight(14)
                 + PurchasePrice.ToString().PadRight(14)
                + CurrencyType.PadRight(14)
                + Utilities.CalculateCurrency(PurchasePrice, CurrencyType).ToString());

            }
        }
        public static void ResultPrinterWithId(int Id, string AssetType, string Name, string Model, int PurchasePrice, DateTime PurchaseDate, string CurrencyType, string OfficeName)
        {
            Console.WriteLine(
                Id.ToString().PadRight(4) +
                AssetType.PadRight(12)
                 + Name.PadRight(12)
                 + Model.PadRight(12)
                 + OfficeName.PadRight(12)
                 + PurchaseDate.ToShortDateString().PadRight(12)
                 + PurchasePrice.ToString().PadRight(12)
                 + CurrencyType.PadRight(12)
                 + Utilities.CalculateCurrency(PurchasePrice, CurrencyType).ToString()); ;

        }
    }
}
