using System;
using System.Collections;

class InfixToPostfix
{
    static int GetPrecedence(char ch)
    {
        switch (ch)
        {
            case '+':
            case '-': return 1;
            case '*':
            case '/': return 2;
        }
        return -1;
    }

    public static string ConvertToPostfix(string infix)
    {
        Stack stack = new Stack();
        string postfix = "";

        foreach (char ch in infix)
        {
            if (char.IsLetterOrDigit(ch))
            {
                postfix += ch;
            }
            else if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                while (stack.Count > 0 && (char)stack.Peek() != '(')
                {
                    postfix += stack.Pop();
                }
                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 && GetPrecedence((char)stack.Peek()) >= GetPrecedence(ch))
                {
                    postfix += stack.Pop();
                }
                stack.Push(ch);
            }
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop();
        }

        return postfix;
    }

    static void Main()
    {
        Console.Write("Enter an infix expression: ");
        string infix = Console.ReadLine();
        string postfix = ConvertToPostfix(infix);
        Console.WriteLine("Postfix Expression: " + postfix);
    }
}
