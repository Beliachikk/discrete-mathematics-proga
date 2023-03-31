using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace methods_stack
{
    internal class Program
    {
        static public void Print(Stack<string> st)
        {
            while (st.Count > 0)
            {
                Console.WriteLine(st.Pop()+" ");
            }
        }
        static public void Push(Stack<string> st,string s)//1
        {
            st.Push(s);
            Print(st);
        }
        static public void Clear(Stack<string> st)//2
        {
            st.Clear();
            Print(st);
        }
        static public void Pop(Stack<string> st)//3//извлекает и возвращает первый элемент из стека с удалением
        {
            Console.WriteLine(st.Pop());
            Print(st);
        }
        static public void Peek(Stack<string> st)//4//извлекает и возвращает первый элемент из стека без удаления
        {
            Console.WriteLine(st.Peek());
            Print(st);
        }
        static public void Contains(Stack<string> st,string s)//5
        {
            Console.WriteLine(st.Contains(s));
           
        }
        static public void CopyTo(Stack<string> st)//6
        {
            string[] array = new string[st.Count * 2];
            st.CopyTo(array, st.Count);
            for(int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+" ");
            }

        }
        static public void ToArray(Stack<string> st)//7
        {
            Stack<string> st2 = new Stack<string>(st.ToArray());
            Print(st2);
        }
        static public void Count(Stack<string> st)//8
        {
         Console.WriteLine(st.Count);
        }
        static public void Equals(Stack<string> st)//9
        {
 
           Console.WriteLine(st.Equals(st));//по приколу проверим равен ли стэк самому себе, мне просто лень новый стэк создавать
        }
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("one");
            st.Push("two");
            st.Push("[sdf]{()");

            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "Push", "Clear", "Pop", "Peek", "Contains", "CopyTo", "ToArray", "Count", "Equals" };
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
                           Push(st,"three");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            Clear(st);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            Pop(st);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            Peek(st);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            Contains(st, "two");

                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            CopyTo(st);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            ToArray(st);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            Count(st);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                           Equals(st);
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
