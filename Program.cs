using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace methods_hashtable
{
    internal class Program//ТУТ ВСЕГО 7 МЕТОДОВ, ДИКО ИЗВИНЯЮСЬ, Я БОЛЬШЕ НЕ НАШЛА
    {
        public static void PrintV(Hashtable t)
        {
            ICollection c=t.Keys;
            foreach(string str in c)
                Console.WriteLine(str + ":" + t[str]);
        }
        public static void Add(Hashtable t,string a,string b,int count)//1
        {
            for (int i = 0; i < count; i++)
            {
                t.Add(a, b);
                
            }
            PrintV(t);
        }
        public static void ContainsKey(Hashtable t,string s)//2
        {
           Console.WriteLine(t.ContainsKey(s));
        }
        public static void ContainsValue(Hashtable t, string s)//3
        {
            Console.WriteLine(t.ContainsValue(s));
        }
        public static void Clear(Hashtable t)//4
        {
            t.Clear();
            PrintV(t);
        }
        public static void CopyTo(Hashtable t, string[] a)//5
        {
            t.Values.CopyTo(a, 2);
           // PrintV(t);
           for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static void Remove(Hashtable t, string key)//6
        {
           t.Remove( key);
            PrintV(t);
        }
        public static void Synchronized(Hashtable t)//7
        {
            Hashtable hts = Hashtable.Synchronized(t);
            Console.WriteLine("hts is {0}.", hts.IsSynchronized ? "synchronized" : "not synchronized");
        }
        static void Main(string[] args)
        {
           Hashtable ht = new Hashtable();
            ht.Add("key", "value");
            ht.Add("A", "valueA");
            ht.Add("B", "valueB");
            string[] myTargetArray = new string[15];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumps";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
            myTargetArray[8] = "dog";
            bool k = true;

            while (k == true)
            {
                Console.Clear();
                string[] menu = new string[] { "Add", " ContainsKey", "ContainsValue", "Clear", "CopyTo", "Remove", "Synchronized" };
                Console.WriteLine($"{menu[0]}\n{menu[1]}\n{menu[2]}\n{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n");
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
                            Add(ht,"x", "y",1);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 1)
                        {
                            Console.Clear();
                            ContainsKey(ht,"key");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 2)
                        {
                            Console.Clear();
                            ContainsValue(ht,"value");
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 3)
                        {
                            Console.Clear();
                            Clear(ht);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 4)
                        {
                            Console.Clear();
                            CopyTo(ht, myTargetArray);
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 5)
                        {
                            Console.Clear();
                            Remove(ht, "key");
                            
                            Thread.Sleep(3000);
                            x = false;
                        }
                        else if (ke.Key == ConsoleKey.Enter && j == 6)
                        {
                            Console.Clear();
                            Synchronized(ht);
                            Thread.Sleep(3000);
                            x = false;
                        }
                       
                        // управление консоли
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 6) || (ke.Key == ConsoleKey.UpArrow && j == 1))
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
                        else if ((ke.Key == ConsoleKey.DownArrow && j == 5) || (ke.Key == ConsoleKey.UpArrow && j == 0))
                        {
                            Console.SetCursorPosition(35, 6);
                            j = 6;
                        }
                       
                    }

                }

            }
        }
    }
}
