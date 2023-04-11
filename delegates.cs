using delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    interface Ioperation
    {
        double Add(double x, double y);
        double Diff(double x, double y);
        double Multiply(double x, double y);
        double Div(double x, double y);
    }
    internal class Program: Ioperation
    {

    double Ioperation.Add(double x, double y)
        {
            return x + y;
        }
        double Ioperation.Diff(double x, double y)
        {
            return x - y;
        }
        double Ioperation.Multiply(double x, double y)
        {
            return x* y;
        }
        double Ioperation.Div(double x, double y)
        {
            return x/y;
        }
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            double value1, value2;
            string action;
            Console.WriteLine("Введите значение 1:");
            value1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 2:");
            value2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию + - / *");
            action = Console.ReadLine();

            Ioperation obj=new Program();
           
            switch (action)
            {
                case "+":
                    Console.WriteLine(obj.Add(value1, value2));
                    break;
                case "-":
                    Console.WriteLine(obj.Diff(value1, value2));
                    break;
                case "/":
                    if (value2 == 0)
                        Console.WriteLine("На ноль делить нельзязязязяз");
                    else
                    Console.WriteLine(obj.Multiply(value1, value2));
                    break;
                case "*":
                    Console.WriteLine(obj.Div(value1, value2));
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
        }
    }
}
