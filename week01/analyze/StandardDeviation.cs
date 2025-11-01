/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation {
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

     private static double StandardDeviation1(int[] numbers)
    {
        double total = 0.0;
        int count = 0;

        foreach (var number in numbers)
        {
            total += number;
            count++;
        }

        double avg = total / count;
        double sumSquaredDifferences = 0.0;

        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        double variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }

    private static double StandardDeviation2(int[] numbers)
    {
        double sumSquaredDifferences = 0.0;
        int countNumbers = 0;

        foreach (var number in numbers)
        {
            double total = 0;
            int count = 0;

            foreach (var value in numbers)
            {
                total += value;
                count++;
            }

            double avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers++;
        }

        double variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);
    }

    private static double StandardDeviation3(int[] numbers)
    {
        int count = numbers.Length;
        double avg = (double)numbers.Sum() / count;
        double sumSquaredDifferences = 0.0;

        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        double variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
}