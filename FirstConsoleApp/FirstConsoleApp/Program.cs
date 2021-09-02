using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 40;
            double grossPay, netPay, payRate = 25.0;

            grossPay = hours * payRate;
            netPay = grossPay * 0.8;

            Console.WriteLine($"Your pay summary:\n" +
                              $"Gross Pay\t| Net Pay\n" +
                              $"{grossPay}\t\t| {netPay}");
        }
    }
}
