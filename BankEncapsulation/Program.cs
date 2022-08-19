// See https://aka.ms/new-console-template for more information
using BankEncapsulation;

Console.WriteLine("How much would you like to deposit");
var amount = double.Parse(Console.ReadLine());
var account = new BankAccount(amount);
Console.WriteLine($"Your new Balance is: {account.GetBalance()}");
