using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace queue_methods
{
    internal class Program
    {
        public static void PrintValues(Array myArr, char mySeparator)
        {
            foreach (Object myObj in myArr)
            {
                Console.Write("{0}{1}", mySeparator, myObj);
            }
            Console.WriteLine();
        }
        public static void Print(Queue q)
        {
            Console.Write("Содержимое очереди:");
            foreach (string i in q)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        public static void ShowEnq(Queue q,string a)//1 помещаем в очередь
        {
            q.Enqueue(a);
            Console.WriteLine("Поместить в очередь:Enqueue(" + a + ")");
            Print(q);
        }
        public static void ShowDeq(Queue q)//2 возвращает и удаляет объект из начала очереди
        {
            Console.Write("Извлечь из очереди:Dequeue->");
            string a=(string)q.Dequeue(); 
            Console.WriteLine(a);
            Print(q);
        }
        public static void Clear(Queue q)//3
        {
            q.Clear();
            Print(q);
        }
        public static void Contains(Queue q,string a)//4
        {
           Console.WriteLine( q.Contains(a));
        }
        public static void Peek(Queue q)
        {
            Console.Write("Извлечь из очереди:Peek->");//5 типа dequeue, но без удаления
            string a = (string)q.Peek();
            Console.WriteLine(a);
            Print(q);
        }
        public static void ToArray(Queue q,Array a)//6 возвращает массив, который хранит копии элементов из очередиии
        {
            q.CopyTo(a, 6);
            Console.WriteLine("Содержимое массива с копиями:");
            PrintValues(a, ' ');
        }
        public static void TrimToSize(Queue q)//7
        {
            q.TrimToSize();
            Print(q);
        }

        public static void Synchronized(Queue q)//8
        {
            Console.WriteLine(q.IsSynchronized);
        }
        public static void TrimExcess(Queue q)//9 эта штука позволяет избавиться от пустых элементов в начале очереди
        {
            TrimExcess(q);
            Print(q);
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
           q.Enqueue("three");
            q.Enqueue("napping");
            q.Enqueue("cats");
           q.Enqueue("in");
            q.Enqueue("the");
           q.Enqueue("barn");

            Array myTargetArray = Array.CreateInstance(typeof(string), 15);
            myTargetArray.SetValue("The", 0);
            myTargetArray.SetValue("quick", 1);
            myTargetArray.SetValue("brown", 2);
            myTargetArray.SetValue("fox", 3);
            myTargetArray.SetValue("jumps", 4);
            myTargetArray.SetValue("over", 5);
            myTargetArray.SetValue("the", 6);
            myTargetArray.SetValue("lazy", 7);
            myTargetArray.SetValue("dog", 8);
            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "ShowEnq", "ShowDeq", "Clear", "Contains", "Peek", "ToArray", "TrimToSize", "Synchronized", "Reverse" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n{menu[7]}\n{menu[8]}\n");
                Console.SetCursorPosition(30, 0);
                bool x = true;
                int j = 0;
                for (int i = 0; x == true;)
                {
                    ConsoleKeyInfo ke = Console.ReadKey(true);
                    if (i == 0)
                    {
                        if (ke.Key == ConsoleKey.Enter && j == 0)
                        {
                            Console.Clear();
                            ShowEnq(q,"2");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            ShowDeq(q);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            Clear(q);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            Contains(q,"three");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            Peek(q);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            ToArray(q, myTargetArray);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            TrimToSize(q);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            Synchronized(q);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                            TrimExcess(q);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        // управление консоли
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 8) || (ke.Key == ConsoleKey.UpArrow && j == 1))
                        {
                            Console.SetCursorPosition(35, 0);
                            j = 0;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 0) || (ke.Key == ConsoleKey.UpArrow && j == 2))
                        {
                            Console.SetCursorPosition(35, 1);
                            j = 1;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 1) || (ke.Key == ConsoleKey.UpArrow && j == 3))
                        {
                            Console.SetCursorPosition(35, 2);
                            j = 2;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 2) || (ke.Key == ConsoleKey.UpArrow && j == 4))
                        {
                            Console.SetCursorPosition(35, 3);
                            j = 3;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 3) || (ke.Key == ConsoleKey.UpArrow && j == 5))
                        {
                            Console.SetCursorPosition(35, 4);
                            j = 4;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 4) || (ke.Key == ConsoleKey.UpArrow && j == 6))
                        {
                            Console.SetCursorPosition(35, 5);
                            j = 5;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 5) || (ke.Key == ConsoleKey.UpArrow && j == 7))
                        {
                            Console.SetCursorPosition(35, 6);
                            j = 6;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 6) || (ke.Key == ConsoleKey.UpArrow && j == 8))
                        {
                            Console.SetCursorPosition(35, 7);
                            j = 7;
                        }
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 7) || (ke.Key == ConsoleKey.UpArrow && j == 0))
                        {
                            Console.SetCursorPosition(35, 8);
                            j = 8;
                        }
                    }

                }

            }
        }
    }
}
