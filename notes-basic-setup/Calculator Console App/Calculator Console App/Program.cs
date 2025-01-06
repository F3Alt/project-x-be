using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! I help you calculate numbers.");
            Console.WriteLine();

            bool isRepeating = true;
            while (isRepeating)
            {
                int firstNum = ReadInt("Enter first number: ");

                Console.WriteLine("Choose the operator:");
                Console.WriteLine("1. Plus (+)");
                Console.WriteLine("2. Minus (-)");
                Console.WriteLine("3. Divide (/)");
                Console.WriteLine("4. Multiply (*)" + Environment.NewLine);

                string operatorInp = ReadString("Enter the operator: ");
                while (!IsValidOperator(operatorInp))
                {
                    Console.WriteLine("Invalid operator. Please enter a valid operator.");
                    operatorInp = ReadString("Enter the operator: ");
                }

                int secondNum = ReadInt("Enter second number: ");

                double result = 0.0;
                bool isCorrectInput = true;

                if (IsOperatorMatch(operatorInp, "+", "plus", "1"))
                {
                    result = firstNum + secondNum;
                    operatorInp = "+";
                }
                else if (IsOperatorMatch(operatorInp, "-", "minus", "2"))
                {
                    result = firstNum - secondNum;
                    operatorInp = "-";
                }
                else if (IsOperatorMatch(operatorInp, "/", "divide", "3"))
                {
                    if (secondNum != 0)
                    {
                        result = (double)firstNum / secondNum;
                        operatorInp = "/";
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        isCorrectInput = false;
                    }
                }
                else if (IsOperatorMatch(operatorInp, "*", "multiply", "4"))
                {
                    result = firstNum * secondNum;
                    operatorInp = "*";
                }
                else
                {
                    isCorrectInput = false;
                }

                if (isCorrectInput)
                {
                    Console.WriteLine(Environment.NewLine + "The result of " + firstNum + " " + operatorInp + " " + secondNum + " is: " + result);
                }
                else
                {
                    Console.WriteLine("Incorrect Operator or Input.");
                }

                string repeatInput = ReadString("Calculate again? (yes/no): ");
                isRepeating = repeatInput.ToLower().StartsWith("y");
            }

            Console.WriteLine("Thank you for using this calculator.");

            Console.ReadLine();
        }

        public static string ReadString(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public static int ReadInt(string input)
        {
            int number;
            while (!int.TryParse(ReadString(input), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return number;
        }

        public static bool IsOperatorMatch(string input, string symbol, string word, string number)
        {
            return input.Contains(symbol) || input.ToLower().Contains(word) || input.Contains(number);
        }

        public static bool IsValidOperator(string input)
        {
            return IsOperatorMatch(input, "+", "plus", "1") ||
                   IsOperatorMatch(input, "-", "minus", "2") ||
                   IsOperatorMatch(input, "/", "divide", "3") ||
                   IsOperatorMatch(input, "*", "multiply", "4");
        }
    }
}
