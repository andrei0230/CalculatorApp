using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    static class Calculator
    {
        private static string ShuntingYard(string input)
        {
            string output = string.Empty;

            // Code goes here

            return output;
        }
        public static string Solve(string input)
        {
            string output = string.Empty;

            string[] temp = input.Split(' ');

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

                    switch(s[0])
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
