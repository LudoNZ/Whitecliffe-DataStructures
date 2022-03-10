using System;
using System.Collections.Generic;

namespace ExpressionValidation_20210741
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Student 20210741 Working some magic!!");

            AutoTest();

            UserControl();

            Console.ReadLine();
        }

        static bool ValidateExpression(string expression, char openChar, char closeChar)
        {
            Stack<char> stack = new Stack<char>();

            //evaluate each character from left to right.
            foreach(char c in expression)
            {
                //match Open bracket
                if(c == openChar)
                {
                    stack.Push(c);
                }
                //match Close bracket
                else if(c == closeChar)
                {
                    //check if stack is empty (Error handling)
                    if(stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char x = stack.Pop();
                    }
                }
            }
            return stack.Count == 0;
        }

        static void UserControl()
        {
            Console.Write("please enter an expression to validate: ");
            Console.ReadLine();

            Console.Write("please enter the types of bracket to test");
        }

        static bool Test(string input, char typeOpen, char typeClosed, bool expectedResult)
        {
            //Console.Write($"Test: {input}\n   results: ");
            return ValidateExpression(input, typeOpen, typeClosed) == expectedResult;
        }

        static void AutoTest()
        {
            Console.WriteLine("Testing:");
            Console.WriteLine(Test("[3, 4], [5.6, 7], [[8, 9]", '[', ']', false));
            Console.WriteLine(Test("{{a, b, c}, {d}, {f, g, h, i}}", '{', '}', true));
            Console.WriteLine(Test("(<Hello>, <Is it me you’re looking for?)", '<', '>', false));
            Console.WriteLine(Test("(a+b))*(c+d ", '(', ')', false));
            Console.WriteLine(Test("())", '(', ')', false));
            Console.WriteLine(Test("{{{}}}", '{', '}', true));
        }

    }
}
