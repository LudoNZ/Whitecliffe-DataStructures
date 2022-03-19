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

        //Check Expression has correct amount of provided brackets.
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
                        stack.Pop();
                    }
                }
            }
            return stack.Count == 0;
        }

        //hand over control to user for input.
        static void UserControl()
        {
            Console.Write("Enter expression to validate: ");
            string expression = Console.ReadLine();

            Console.Write("  - characters to match: ");
            char openBracket = Console.ReadKey().KeyChar;

            Console.Write(" and ");
            char closeBracket = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string result = ValidateExpression(expression, openBracket, closeBracket) ? "correct" : "incorrect";
            Console.WriteLine($"Result: {result}");
        }

        //Run tests to verify the code solution against pre determined test inputs.
        static void AutoTest()
        {
            Console.WriteLine("Auto Test Results:");
            Console.WriteLine(Test("[3, 4], [5.6, 7], [[8, 9]", '[', ']', false));
            Console.WriteLine(Test("{{a, b, c}, {d}, {f, g, h, i}}", '{', '}', true));
            Console.WriteLine(Test("(<Hello>, <Is it me you’re looking for?)", '<', '>', false));
            Console.WriteLine(Test("(a+b))*(c+d ", '(', ')', false));
            Console.WriteLine(Test("())", '(', ')', false));
            Console.WriteLine(Test("{{{}}}", '{', '}', true));
        }

        static bool Test(string input, char typeOpen, char typeClosed, bool expectedResult)
        {
            //Console.Write($"Test: {input}\n   results: ");
            return ValidateExpression(input, typeOpen, typeClosed) == expectedResult;
        }
    }
}
