using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skobki_stack
{
    internal class Program
    {
        static void Sort(Stack<char> chStack)//сортируем исходный стек
        {
            if (chStack.Count == 0)
                return;
            char element = chStack.Pop(); 
            Sort(chStack);//рекурсия хы
            RearrangeAndInsert(chStack, element);
        }

        static void RearrangeAndInsert(Stack<char> stack, char element)
        {
            if (stack.Count == 0 || element >= stack.Peek())
                stack.Push(element);
            else
            {
                char temp = stack.Pop();
                RearrangeAndInsert(stack, element);
                stack.Push(temp);
            }
        }
        static void Main(string[] args)
        {
            string s = "([){asd}}f]";
            Stack<char> chStack = new Stack<char>();
            foreach (char ch in s)
            {
                chStack.Push(ch);
                Console.WriteLine(ch);
            }
        
            Sort(chStack);

            Stack<char> chStack2 = new Stack<char>();
            while (chStack.Count > 0)
            { 
              var a=chStack.Pop();
                if (chStack2.Contains(a))
                {
                    continue;
                }
                chStack2.Push(a);
            }
            Console.WriteLine("Второй стек");
           
           
                if (chStack2.Contains('{') && chStack2.Contains('}'))
                {
                        Console.Write("{} присутсвуют в тексте и расставлены правильно\n");
                }
                if (chStack2.Contains('(') && chStack2.Contains(')'))
                {
                        Console.Write("() присутсвуют в тексте и расставлены правильно\n");
                }
                if (chStack2.Contains('[') && chStack2.Contains(']'))
                {
                   Console.Write("[] присутсвуют в тексте и расставлены правильно");
                }
                Console.ReadLine();
            
           
        }

       
    }
}
