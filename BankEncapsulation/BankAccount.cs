using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount(double amount)
        {
            balance = amount;  
        }
        private double balance = 0;
        
        public static double Deposit()
        {

            Console.WriteLine("Please enter amount to deposit: ");
            bool deposit = double.TryParse(Console.ReadLine(), out double newDeposit);

            while(deposit == false)
            {
                Console.WriteLine("Please try again");
                break;
            }
            return newDeposit;
         }

       
        public double GetBalance()
        {

            return balance;
            
        }
    }
}
