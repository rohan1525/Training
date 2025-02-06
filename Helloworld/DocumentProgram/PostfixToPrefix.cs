using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PostfixToPrefix
{
    public static string ConvertPostfixToPrefix(string postfix)
    {
        Stack<string> stack = new Stack<string>();

        foreach (char ch in postfix)
        {
            if (char.IsLetterOrDigit(ch)) 
            {
                stack.Push(ch.ToString());
            }
            else
            {
                string op1 = stack.Pop();
                string op2 = stack.Pop();
                string newExp = ch + op2 + op1;
                stack.Push(newExp);
            }
        }
        return stack.Pop();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a postfix expression: ");
        string postfix = Console.ReadLine();

        string prefix = ConvertPostfixToPrefix(postfix);
        Console.WriteLine("Prefix Expression: " + prefix);
    }
}
