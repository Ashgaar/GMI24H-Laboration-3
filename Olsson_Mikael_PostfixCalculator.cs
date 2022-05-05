using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Mikael_Olsson_PostfixCalculator : ILaboration_3_PostfixCalculator
    {
        public int Calculate(String expression)
        {
            Mikael_Olsson_Stack stack = new Mikael_Olsson_Stack();
            
            string[] subs = expression.Split(' ');

            for (int i = 0; i < subs.Length; i++)
            {
                if (subs[i] == "+" || subs[i] == "-" || subs[i] == "*" || subs[i] == "/")
                {
                    int a = stack.Pop();
                    int b = stack.Pop();

                    stack.Push(Operator(subs[i], a, b));
                }
                else
                {
                    stack.Push(int.Parse(subs[i]));
                }
            }

            return stack.Top();
        }
        
        public int Operator(string logic, int a, int b)
        {
            switch (logic)
            {
                case "+": return b + a;
                case "-": return b - a;
                case "*": return b * a;
                case "/": return b / a;
                default: throw new Exception("something went wrong");
            }
        }
    }
}
