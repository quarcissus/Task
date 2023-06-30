using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LuxoftTaskGerardoAcostaOlvera
{

    
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(ReturnChange(36.43m, new decimal[] { 46.5m }));
        }
        /// <summary>
        /// Will return the optimum number of bills and coins based on the Item price and customer payment
        /// </summary>
        /// <param itemPrice="decimal">Price of the Item</param>
        /// <param customerPayment="decimal[]">All the bills and coins payed by the customer</param>
        /// <return>Will return a string with all the bills and coins that must be given to the customer</return>
        public static string ReturnChange(decimal itemPrice, decimal[] customerPayment)
        {
            try
            {
                StringBuilder moneyToReturn = new StringBuilder();
                decimal customerPaymentSum = customerPayment.Sum();
                decimal customerChange = customerPaymentSum - itemPrice;

                if (itemPrice < 0) throw new Exception("Item Price must be greater than 0");
                if (customerChange == 0) return "0USD";
                if (itemPrice == 0) return $"{customerPaymentSum}{COUNTRYGLOBALDATA.CURRENCYCODE}";
                if (itemPrice > customerPaymentSum) throw new Exception("Customer payment insufficient");

                for (var i = COUNTRYGLOBALDATA.DENOMINATION.Length-1; i >=0; i--)
                {
                    if (customerChange == 0) break;
                    if (COUNTRYGLOBALDATA.DENOMINATION[i] > customerChange) continue;
                    var currentMoneyQuantity = Math.Floor(customerChange / COUNTRYGLOBALDATA.DENOMINATION[i]);
                    customerChange -= (COUNTRYGLOBALDATA.DENOMINATION[i] * currentMoneyQuantity);
                    moneyToReturn.Append($"{currentMoneyQuantity} of {COUNTRYGLOBALDATA.DENOMINATION[i]}{COUNTRYGLOBALDATA.CURRENCYCODE}, ");
                }
                
                return moneyToReturn.Remove(moneyToReturn.Length-2, 2).ToString();
            }
            catch (Exception ex)
            {
                /// <summary>
                /// Exceptions handled by the Return Change function:
                /// Item Price is less than zero (Price cannot be less than zero)
                /// Item Price is greater than the customer payment (Customer needs to give more money)
                /// </summary>
                Console.WriteLine($"{ex.Message}");
                return ex.Message;
            }
        }
        
    }
}
