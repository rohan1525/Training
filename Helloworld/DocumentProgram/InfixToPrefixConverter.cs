using System;
using System.Collections.Generic;

public class InfixToPrefixConverter
{
    static int Precedence(char op)
    {
        return (op == '+' || op == '-') ? 1 : (op == '*' || op == '/') ? 2 : 0;
    }

    static string InfixToPrefix(string infix)
    {
        Stack<char> operators = new Stack<char>();
        Stack<string> operands = new Stack<string>();

        for (int i = 0; i < infix.Length; i++)
        {
            char ch = infix[i];

            if (char.IsLetterOrDigit(ch))
            {
                operands.Push(ch.ToString());
            }
            else if (ch == '(')
            {
                operators.Push(ch);
            }
            else if (ch == ')')
            {
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    string op2 = operands.Pop();
                    string op1 = operands.Pop();
                    char op = operators.Pop();
                    operands.Push(op + op1 + op2);
                }
                operators.Pop();
            }
            else
            {
                while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(ch))
                {
                    string op2 = operands.Pop();
                    string op1 = operands.Pop();
                    char op = operators.Pop();
                    operands.Push(op + op1 + op2);
                }
                operators.Push(ch);
            }
        }

        while (operators.Count > 0)
        {
            string op2 = operands.Pop();
            string op1 = operands.Pop();
            char op = operators.Pop();
            operands.Push(op + op1 + op2);
        }

        return operands.Peek();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter infix expression: ");
        string infix = Console.ReadLine();
        string prefix = InfixToPrefix(infix);
        Console.WriteLine("Prefix Expression: " + prefix);
    }
}
