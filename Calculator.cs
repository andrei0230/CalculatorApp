using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    static class Calculator
    {
        public static string Solve(string input)
        {
            string output = string.Empty;

            string[] temp = input.Split(' ');

            Stack<int> stack = new Stack<int>();

            foreach (string s in temp)
            {
                if (s[0] > '0' && s[0] <= '9')
                {
                    int t = int.Parse(s);
                    stack.Push(t);
                }
                else
                {
                    int t1 = stack.Pop();
                    int t2 = stack.Pop();

                    switch(s[0])
                    {
                        case '+': stack.Push(t1 + t2); 
                            break;
                        case '-': stack.Push(t1 - t2);
                            break;
                        case '*': stack.Push(t1 * t2);
                            break;
                    }
                }
            }

            output = stack.Pop().ToString();

            return output;
        }
    }
}
