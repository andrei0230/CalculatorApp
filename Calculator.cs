using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    static class Calculator
    {
        private static int Precedence(string input)
        {
            int output = 0;
            switch (input)
            {
                case "+": return output = 2;
                case "-": return output = 2;
                case "*": return output = 3;
                case "/": return output = 3;
            }

            return output;
        }
        public static string ShuntingYard(string input)
        {
            string output = string.Empty;

            string[] temp = input.Split(' ');

            StringBuilder builder = new StringBuilder();

            Stack<string> operators = new Stack<string>();  

            foreach (string token in temp)
            {
                if (token[0] > '0' && token[0] <= '9')
                {
                    builder.Append($"{token} ");
                }
                else if (token[0] == '(')
                {
                    operators.Push(token);
                }
                else if (token[0] == '+' || token[0] == '-' || token[0] == '*' || token[0] == '/')
                {
                    while ((operators.Count > 1 &&(operators.Peek())[0] != '(') && Precedence(operators.Peek()) >= Precedence(token))
                    {
                        builder.Append($"{operators.Pop()} "); 
                    }
                    operators.Push(token);
                }
                else if (token[0] == ')')
                {
                    while ((operators.Peek())[0] != '(')
                    {
                        builder.Append($"{operators.Pop()} ");
                    }
                    operators.Pop();
                }
            }
            while (operators.Count > 0)
                {
                    if(operators.Count == 1)
                    builder.Append($"{operators.Pop()}");
                    else
                    builder.Append($"{operators.Pop()} ");
                }

            output = builder.ToString();

            return output;
        }
        public static string Solve(string input)
        {
            string output = string.Empty;

            string[] temp = ShuntingYard(input).Split(' ');

            Stack<double> stack = new Stack<double>();

            foreach (string s in temp)
            {
                if (s[0] > '0' && s[0] <= '9')
                {
                    double t = double.Parse(s);
                    stack.Push(t);
                }
                else
                {
                    double t1 = stack.Pop();
                    double t2 = stack.Pop();

                    switch (s[0])
                    {
                        case '+': stack.Push(t1 + t2); 
                            break;
                        case '-': stack.Push(t1 - t2);
                            break;
                        case '*': stack.Push(t1 * t2);
                            break;
                        case '/': stack.Push(t1 / t2);
                            break;
                    }
                }
            }

            output = stack.Pop().ToString();

            return output;
        }
    }
}
