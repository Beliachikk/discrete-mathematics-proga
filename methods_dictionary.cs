using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//для dictionary тут не так много методов доступных для .net framework ,НО вы разрешили еще Hash Set впихнуть хы

namespace dictionary_methods//оказывается обобщенный вариант класса hashtable это dictionary,шок
{
    internal class Program
    {
        public static void Print(Dictionary<string, double> d1)
        {
            ICollection<string> c = d1.Keys;
            foreach(string str in c)
            {
                Console.WriteLine("{0}:{1} ", str, d1[str]);
            }
        }
        public static void Add(Dictionary<string , double> d1,string a,double b)//1
        {
            d1.Add(a,b);
            Print(d1);
        }
        public static void ContainsKey(Dictionary<string, double> d1, string a)//2
        {
            Console.WriteLine(d1.ContainsKey(a));
        }
        public static void ContainsValue(Dictionary<string, double> d1, double b)//3
        {
            Console.WriteLine(d1.ContainsValue(b));
        }
        public static void Remove(Dictionary<string, double> d1, string a)//4
        {
            Console.WriteLine(d1.Remove(a));
            Print(d1);
        }
        public static void Clear(Dictionary<string, double> d1)//5
        {
            d1.Clear();
            Print(d1);
        }
        public static void CopyTo(HashSet<char> set1, char[] chars)//6
        {
            set1.CopyTo(chars);
            Console.WriteLine("Получаем массив");
            for (int i=0; i < chars.Length; i++)
            {
                Console.WriteLine((char)chars[i]);
            }
        }
        public static void SetEquals(HashSet<char> set1, HashSet<char> set2)//7
        {        
            Console.WriteLine(set1.SetEquals(set2));
        }
        public static void Contains(HashSet<char> set1,char c)//8
         {
            Console.WriteLine(set1.Contains(c));
        }
        public static void RemoveForHashSet(HashSet<char> set1, char c)//8
        {
           
            Console.WriteLine(set1.Remove('d'));
            foreach (int i in set1)
                Console.Write(" {0}", i);
        }
        
        static void Main(string[] args)
        {
            Dictionary<string,double> d1 = new Dictionary<string,double>();
            d1.Add("Петя",1);
            d1.Add("Маша", 2);
            HashSet<char> set1 = new HashSet<char>();
            set1.Add('a');
            set1.Add('b');
            set1.Add('c');
            HashSet<char> set2 = new HashSet<char>();
            set2.Add('d');
            set2.Add('e');
            set2.Add('d');
            char[] chars = new char[3];
            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { " Add", " ContainsKey", "ContainsValue", "Remove", "Clear", "CopyTo", "SetEquals", "Contains", "RemoveForHashSet" };
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
                            Add(d1,"Алёна",4);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            ContainsKey(d1,"Маша");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            ContainsValue(d1,1);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            Remove(d1,"Маша");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            Clear(d1);
                            
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            CopyTo(set1, chars);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            SetEquals(set1, set2);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 7)
                        {
                            Console.Clear();
                            Contains(set1, 'a');
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 8)
                        {
                            Console.Clear();
                            RemoveForHashSet(set2,'d');
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
