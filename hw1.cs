using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter operator (+,-,*,/) ");
            char op = Console.ReadLine()[0];
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool ValidOperation = true;

            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
               result = num1 * num2;
            }
            else if (op == '/')
            {
                if (num2 == 0)
                {
                     Console.WriteLine("invalid operation");
                     ValidOperation = false;
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else
            {
                Console.WriteLine("invalid operator");
                ValidOperation = false;
            }
            

            if (ValidOperation)
            {
                Console.WriteLine($"result: {result}");
            }
            
            Console.Write("Do you want to calculate again? Yes/No: ");
            if (Console.ReadLine().ToLower() != "yes")
            {
                break;
            }
            
        }
        
        
    }
}