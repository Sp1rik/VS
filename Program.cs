using System;
using System.Globalization;
using System.IO.Pipelines;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 1 число: ");
        Double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число: ");
        Double number2 = Convert.ToDouble(Console.ReadLine());

        Double result = number1 + number2;
        Console.WriteLine($"Результат: {result}");


    }
}