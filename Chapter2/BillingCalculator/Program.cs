using System;

namespace BillingCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up the order
            double subtotal = 49.99;

            // Calculate tax and total
            double tax = Calculator.CalculateTax(subtotal);
            double total = Calculator.CalculateTotal(subtotal, tax);

            double outOfStateSubtotal = 80.00;
            double outOfStateTax = Calculator.CalculateTax(outOfStateSubtotal, taxRate: 0.05);
            double outOfStateTotal = Calculator.CalculateTotal(outOfStateSubtotal, outOfStateTax);

            Console.WriteLine($"\nOut-of-state subtotal: {outOfStateSubtotal:C}");
            Console.WriteLine($"Out-of-state tax:      {outOfStateTax:C}");
            Console.WriteLine($"Out-of-state total:    {outOfStateTotal:C}");

            // Print the receipt
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Tax:      {tax:C}");
            Console.WriteLine($"Total:    {total:C}");
        }
    }

    public static class Calculator
    {
        public static double CalculateTax(double subtotal, double taxRate = 0.08)
        {
            return subtotal * taxRate;
        }

        public static double CalculateTotal(double subtotal, double tax)
        {
            return subtotal + tax;
        }
    }
}
