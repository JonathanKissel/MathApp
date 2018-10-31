using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press any other button to Exit");
            string answer =(Console.ReadLine());
            

            if (answer == "1")
            {
                Console.WriteLine("Enter the 1st Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd Number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                double solution = Addition(num1, num2);
                Console.WriteLine(num1 + " + " + num2 + " = " + solution);
                Console.ReadLine();          
            } 
            
            else if (answer == "2")
            {
                Console.WriteLine("Enter the 1st Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd Number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                double solution = Subtraction(num1, num2); 
                Console.WriteLine(num1 + " - " + num2 + " = " + solution);
                Console.ReadLine();
            }
           else if (answer == "3")
            {
                Console.WriteLine("Enter the 1st Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd Number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                double solution = Multiplication(num1, num2);
                Console.WriteLine(num1 + " * " + num2 + " = " + solution);
                Console.ReadLine();
            }
           else if (answer == "4")
            {
                Console.WriteLine("Enter the 1st Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd Number");
                int num2 = 0;
                while (!int.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                {
                    Console.WriteLine("Second number can't be Zero");
                    Console.WriteLine("Please enter a second number");
                }
                double solution = Division(num1, num2);
                Console.WriteLine(num1 + " / " + num2 + " = " + solution);
                Console.ReadLine();
            } 
            else
            {

                Console.WriteLine("Thanks For Stopping By");
                Console.ReadLine();

            }


        }
        static public double Addition(double num1,  double num2)
        {
            return (num1) + (num2);
        }

        static public double Subtraction(double num1, double num2)
        {
            return (num1) - (num2);
        }

        static public double Multiplication(double num1, double num2)
        {
            return (num1) * (num2);
        }

        static public double Division(double num1, double num2)
        {
            return (num1) / (num2);
        }
    }
}
