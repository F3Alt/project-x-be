using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, I help you calculate the numbers.");
            Console.WriteLine();

            int firstNum = readInt("Enter first number: ")

            Console.WriteLine("Choose the operator");
            Console.WriteLine("1. Plus (+)");
            Console.WriteLine("2. Minus (-)");
            Console.WriteLine("3. Divide(/)");
            Console.WriteLine("4.Multiply(*)" + Environment.NewLine);

            string operatorInp = readString("Enter the operator: ");
            int secondNum = readInt("Enter second number: ");

            double result = 0.0;


            if (operatorInp.Contains("+") || operatorInp.toLower().Contains("plus") || operatorInp.Contains("1"))
            {
                result = firstNum + secondNum;

            }

            else if (operatorInp.Contains("-"))
            {

                result = firstNum - secondNum;
                

            }

            else if (operatorInp.Contains("*"))
            {
                result = firstNum * secondNum;

            }

            else if(operatorInp.Contains("/"))
            {
                result = firstNum / secondNum;

            }

            Console.WriteLine(Environment.NewLine + "The result of " + firstNum + " " + operatorInp + " " + secondNum + " is: " + result );


            Console.ReadLine();
        }

        public static string readString(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public static int readInt(string input)
        {
            return Convert.ToInt32(readString(input));
        }
    }
}
