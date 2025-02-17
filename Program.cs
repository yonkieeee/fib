namespace fibo;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, World!");
        string numbersFilePath = @"D:\\C#projects\\fibo\\fibo\\numbers.txt";
        string outputFilePath = @"D:\\C#projects\\fibo\\fibo\\output.txt";
        string stepsFibo = @"D:\\C#projects\\fibo\\fibo\\stepsFibo.txt";
        
        if (!File.Exists(numbersFilePath))
        {
            Console.WriteLine("File not found");
            return;
        }

        string numbersFromFile = File.ReadAllText(numbersFilePath);
        int stepsFib = int.Parse(File.ReadAllText(stepsFibo));
        var numbers = numbersFromFile.Split(',');

        double firstNumber = double.Parse(numbers[0]);
        double secondNumber = double.Parse(numbers[1]);
        List<double> fibonachi = new List<double>();

        fibonachi.Add(firstNumber);
        fibonachi.Add(secondNumber);

        fibonachiList(fibonachi, stepsFib);
        File.WriteAllText(outputFilePath, string.Empty);
        
        foreach (double fibonachiNumber in fibonachi)
            File.AppendAllText(outputFilePath, fibonachiNumber.ToString() + " ");
        List<double> fibonachiList(List<double> fibonachi, int steps)
        {
    
            if (fibonachi.Count >= steps)
                return fibonachi;

            double next = fibonachi[fibonachi.Count-1] + fibonachi[fibonachi.Count-2];
    
            fibonachi.Add(next);
            return fibonachiList(fibonachi, steps);
        }
    }
}