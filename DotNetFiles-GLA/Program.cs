// See https://aka.ms/new-console-template for more information

using System;

class FinancialCalculator
{
    static void Main()
    {
        int[] transactions = { 200, -150, 340, 500, -100 };
        int totalSum = 0;

        foreach (int amount in transactions)
        {
            totalSum += amount;
        }

        Console.WriteLine("Total sum of all transactions: " + totalSum);
    }
}
