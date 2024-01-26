class BaseView : IBaseView
{
    public ConsoleKeyInfo Menu(ComplexNumber result, int accuracy)
    {
        System.Console.WriteLine("Last result: {0}", result);
        System.Console.WriteLine("Current accuracy: {0}\n", accuracy);
        
        System.Console.WriteLine("Press the key:\n"+
                                 "0. Clear result\n"+
                                 "1. Add\n"+
                                 "2. Sub\n"+
                                 "3. Mul\n"+
                                 "4. Div\n"+
                                 "5. Show last operations\n"+
                                 "6. Set accuracy\n"+
                                 "Esc. Escape");
        return Console.ReadKey();
    }
    public ComplexNumber Input()
    {
        System.Console.Write($"Enter expression: ");
        string? input = Console.ReadLine();
        if (input == null || input == "")
            return new(0,0);
        
        char[] signs = new char[]{'+', '-'};
        input = input.Replace(" ", "");
        string[] tempArr = new string[]{"0", "0"};
        int arrPos = 0;
        string temp = input[0].ToString();
        int pos = 1;
        while (pos < input.Length)
        {
            while (pos < input.Length && !signs.Contains(input[pos]))
            {
                temp += input[pos];
                pos++;
            }
            tempArr[arrPos] = temp;
            arrPos++;
            if (pos < input.Length)
                temp = input[pos].ToString();
            else temp = "";
            pos++;
        }
        if (temp != "")
            tempArr[arrPos] = temp;

        // System.Console.WriteLine($"arrPos: {arrPos} | {tempArr[0]} {tempArr[1]}");
        // Console.ReadKey();

        double real = 0;
        double imaginary = 0;
        if (tempArr[0].Contains('i'))
        {
            imaginary = GetImagCoeff(tempArr[0]);
        }
        else
        {
            real = double.Parse(tempArr[0]);
            if (tempArr[1].Contains('i'))
            {
                imaginary = GetImagCoeff(tempArr[1]);
            }
        }

        return new(real,imaginary);
    }

    private static double GetImagCoeff(string str)
    {
        return str switch
        {
            "i" => 1,
            "-i" => -1,
            _ => double.Parse(str[..^1]),
        };
    }

    public int? SetAccuracy()
    {
        System.Console.Write("Enter the desired precision: ");
        string? temp = Console.ReadLine();
        if (temp == null || temp == "")
            return null;
        if (int.TryParse(temp,out int outNum))
            return outNum;
        return null;
    }
    public void ShowLogs(List<string> logs)
    {
        int num = 1;
        if (logs.Count > 0)
            foreach (string log in logs)
            {
                System.Console.WriteLine($"{num++}. {log}");
            }
        else System.Console.WriteLine("No logs");
        System.Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}