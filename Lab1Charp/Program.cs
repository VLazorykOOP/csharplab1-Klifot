using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть номер завдання від 1 до 6:");
        string input = Console.ReadLine();
        int taskNumber;

        if (int.TryParse(input, out taskNumber) && taskNumber >= 1 && taskNumber <= 6)
        {
            switch (taskNumber)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Номер завдання повинен бути від 1 до 6.");
        }
    }

    static void Task1()
    {
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double average = (Math.Pow(num1, 3) + Math.Pow(num2, 3)) / 2;

        Console.WriteLine("Середнє арифметичне кубів чисел {0} та {1} дорівнює {2}", num1, num2, average);
    }

    static void Task2()
    {
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

       
        bool inside = false; 
        bool onBoundary = false; 

        if (inside)
        {
            Console.WriteLine("Так");
        }
        else if (onBoundary)
        {
            Console.WriteLine("На межі");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }

    static void Task3()
    {
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Замініть ці умови на ваши математичні умови
        bool inside = false; // Замініть це на умову для перевірки, чи знаходиться точка всередині області
        bool onBoundary = false; // Замініть це на умову для перевірки, чи знаходиться точка на межі області

        if (inside)
        {
            Console.WriteLine("Так");
        }
        else if (onBoundary)
        {
            Console.WriteLine("На межі");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }

    static void Task4()
    {
        Console.Write("Введіть номер карти: ");
        int k = Convert.ToInt32(Console.ReadLine());

        string cardName = GetCardName(k);

        Console.WriteLine("Назва карти: " + cardName);
    }

    static string GetCardName(int k)
    {
        string cardName = "";

        switch (k)
        {
            case 14:
                cardName = "туз";
                break;
            case 13:
                cardName = "король";
                break;
            case 12:
                cardName = "дама";
                break;
            case 11:
                cardName = "валет";
                break;
            case 10:
                cardName = "десятка";
                break;
            case 9:
                cardName = "дев'ятка";
                break;
            case 8:
                cardName = "вісімка";
                break;
            case 7:
                cardName = "сімка";
                break;
            case 6:
                cardName = "шістка";
                break;
            default:
                cardName = "Невідома карта";
                break;
        }

        return cardName;
    }

    static void Task5()
    {
        Console.Write("Введіть перше число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        try
        {
            double result = Divide(a, b);
            Console.WriteLine("Результат ділення: " + result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Ділення на нуль неможливе");
        }
        return (double)a / b;
    }

    static void Task6()
    {
        double a = 1.0;
        double b = 2.0;
        double s = 3.0;
        double result = CalculateExpression(a, b, s);
        Console.WriteLine($"The result is {result}");
    }

    static double CalculateExpression(double a, double b, double s)
    {
        return (a * b + (a - b) * (a + b) - 1) / (Math.Pow(a, 2) + Math.Pow(b, 2)) - s;
    }
}
