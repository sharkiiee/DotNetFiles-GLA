using System;

class AnalyticsTool
{
    public static void CalculateTransactionSum()
    {
        int[] transactions = { 200, -150, 340, 500, -100 };
        int total = 0;
        for (int i = 0; i < transactions.Length; i++)
        {
            total += transactions[i];
        }
        Console.WriteLine("Total sum of all transactions: " + total);
    }

    public static void CalculateAverageScore()
    {
        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
        float sum = 0f;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        float average = sum / scores.Length;
        Console.WriteLine("Average score of the class: " + average);
    }

    public static void FindMostExpensiveItem()
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

    public static void CountGenders()
    {
        int[] participantCodes = { 102, 215, 324, 453, 536 };
        int male = 0, female = 0;
        for (int i = 0; i < participantCodes.Length; i++)
        {
            if (participantCodes[i] % 2 == 0)
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

    public static void ReverseSearchHistory()
    {
        int[] searchHistory = { 101, 202, 303, 404, 505 };
        Console.WriteLine("Reversed search history:");
        for (int i = searchHistory.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(searchHistory[i]);
        }
    }

    static void Main()
    {
        CalculateTransactionSum();
        CalculateAverageScore();
        FindMostExpensiveItem();
        CountGenders();
        ReverseSearchHistory();
    }
}
