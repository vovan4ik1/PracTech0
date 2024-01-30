// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program 
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть перше число:");
        string inputNum1 = Console.ReadLine();

        Console.WriteLine("Введіть друге число:");
        string inputNum2 = Console.ReadLine();

        if (double.TryParse(inputNum1, out double number1) && double.TryParse(inputNum2, out double number2))
        {
            double sum = number1 + number2;

            Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює суммі:{sum}");
        }
        else
        {
            Console.WriteLine("Неправильний формат вводу. Будь ласка, Введіть правильний формат введення даних");
        }
    }
}

