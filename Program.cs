using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_proga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 О программе\n2 Об авторе\n3 Калькулятор\n");
            int i = int.Parse(Console.ReadLine());
            

            switch (i)
            {
                case 1:
                    Console.WriteLine("Рргрочка по проге: Калькулятор");
                    Console.WriteLine("При использовании калькулятора: если вы не хотите больше вводить действия, введите н(русскую)");
                    break;
                case 2:
                    Console.WriteLine("Летова Юлия Владимировна ФИТ-221 ");
                    break;
                case 3:
                    double value1, value2;
                    string action;
                    Console.WriteLine("Введите значение 1:");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение 2:");
                    value2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Выберите операцию + - / *");
                    action = Console.ReadLine();
                    double value3 = 0;
                    double value4;
                    while (action != "н")
                    {
                        switch (action)
                        {
                            case "+":
                                value3 = value1 + value2;
                                Console.WriteLine(value3);
                                break;
                            case "-":
                                value3 = value1 - value2;
                                Console.WriteLine(value3);

                                break;
                            case "/":
                                if (value2 == 0)
                                    Console.WriteLine("Ай-яй-яй, на ноль делить нельзя!");
                                else
                                {
                                    value3 = value1 / value2;
                                    Console.WriteLine(value3);
                                }
                                break;
                            case "*":
                                value3 = value1 * value2;
                                Console.WriteLine(value3);
                                break;
                            default:
                                Console.WriteLine("Неизвестная операция");
                                break;
                        }
                        Console.WriteLine("Выберите операцию + - / *");
                        action = Console.ReadLine();
                        if (action != "н")
                        {
                            Console.WriteLine("Введите еще одно значение:");
                            value1 = value3;
                            value4 = double.Parse(Console.ReadLine());
                            value2 = value4;
                        }
                        else
                        {
                            break;
                        }

                    }
                    break;
            }

           
        }
    }
}
