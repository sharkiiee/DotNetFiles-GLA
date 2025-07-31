// See https://aka.ms/new-console-template for more information

using System;

class TransactionSumCalculator
{
    public static void CalculateSum()
    {
        int[] transactions = { 200, -150, 340, 500, -100 };
        int total = 0;
        foreach (int amount in transactions)
        {
            total += amount;
        }
        Console.WriteLine("Total sum of all transactions: " + total);
    }
}

class AverageScoreCalculator
{
    public static void CalculateAverage()
    {
        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
        float sum = 0f;
        foreach (float score in scores)
        {
            sum += score;
        }
        float average = sum / scores.Length;
        Console.WriteLine("Average score of the class: " + average);
    }
}

class MostExpensiveItemFinder
{
    public static void FindMostExpensive()
    {
        int[] prices = { 1500, 2300, 999, 3200, 1750 };
        int max = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > max)
            {
                max = prices[i];
            }
        }
        Console.WriteLine("Most expensive item price: " + max);
    }
}

class GenderCountAnalyzer
{
    public static void CountGenders()
    {
        int[] participantCodes = { 102, 215, 324, 453, 536 };
        int male = 0, female = 0;
        foreach (int code in participantCodes)
        {
            if (code % 2 == 0)
            {
                male++;
            }
            else
            {
                female++;
            }
        }
        Console.WriteLine("Male participants: " + male);
        Console.WriteLine("Female participants: " + female);
    }
}

class SearchHistoryReverser
{
    public static void ReverseHistory()
    {
        int[] searchHistory = { 101, 202, 303, 404, 505 };
        Console.WriteLine("Reversed search history:");
        for (int i = searchHistory.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(searchHistory[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        TransactionSumCalculator.CalculateSum();
        AverageScoreCalculator.CalculateAverage();
        MostExpensiveItemFinder.FindMostExpensive();
        GenderCountAnalyzer.CountGenders();
        SearchHistoryReverser.ReverseHistory();
    }
}


