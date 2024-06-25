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

            int firstNum = ReadInt("Enter first number: ");

            Console.WriteLine("Choose the operator:");
            Console.WriteLine("1. Plus (+)");
            Console.WriteLine("2. Minus (-)");
            Console.WriteLine("3. Divide (/)");
            Console.WriteLine("4. Multiply (*)" + Environment.NewLine);

            string operatorInp = ReadString("Enter the operator: ");
            int secondNum = ReadInt("Enter second number: ");

            double result = 0.0;
            bool isCorrectInput = true;

            if (operatorInp.Contains("+") || operatorInp.ToLower().Contains("plus") || operatorInp.Contains("1"))
            {
                result = firstNum + secondNum;
                operatorInp = "+";
            }
            else if (operatorInp.Contains("-") || operatorInp.ToLower().Contains("minus") || operatorInp.Contains("2"))
            {
                result = firstNum - secondNum;
                operatorInp = "-";
            }
            else if (operatorInp.Contains("/") || operatorInp.ToLower().Contains("divide") || operatorInp.Contains("3"))
            {
                if (secondNum != 0)
                {
                    result = (double)firstNum / secondNum; // Perform division with double to get decimal result
                    operatorInp = "/";
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    isCorrectInput = false;
                }
            }
            else if (operatorInp.Contains("*") || operatorInp.ToLower().Contains("multiply") || operatorInp.Contains("4"))
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
    }
}
