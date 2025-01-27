using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class BankingSystem
    {
        public static void Banking_System()
        {
            //Create a custom exception called InsufficientFundsException.
            //Write a banking application where:
            //A user can withdraw money.
            //Throw InsufficientFundsException if the balance is less than the withdrawal amount.

            Console.WriteLine("Enter amount:");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter balance:");
            int balance = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (balance < amount)
                {
                    throw new InsufficientFundsException("Insufficient funds.");
                }
                else
                {
                    Console.WriteLine("Withdrawal successful.");
                }
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);

            }

            //Product Availability
            //Write a program for an e-commerce application where:
            //If the product stock is 0, throw a ProductOutOfStockException.

            Console.WriteLine("Enter product stock:");
            int stock = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (stock == 0)
                {
                    throw new ProductOutOfStockException("Product out of stock.");
                }
                else
                {
                    Console.WriteLine("Product is available.");
                }
            }
            catch (ProductOutOfStockException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
