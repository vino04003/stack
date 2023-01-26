using System;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string containing brackets:");
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Unbalanced");
                    return;
                }

                char last = stack.Pop();
                if ((c == ')' && last != '(') || (c == ']' && last != '[') || (c == '}' && last != '{'))
                {
                    Console.WriteLine("Unbalanced");
                    return;
                }
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("Balanced");
        }
        else
        {
            Console.WriteLine("Unbalanced");
        }
    }
}
