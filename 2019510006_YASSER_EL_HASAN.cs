using System;

namespace To_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking the value of X and the operator from user controling them to be under required conditions.
            Console.WriteLine("Please enter the value of x to be betweeen 0 and 25 :");
            double x = Convert.ToInt32(Console.ReadLine());
            while (x < 0 | x > 25)
            {
                if (x < 0 | x > 25)
                {
                    Console.WriteLine("WRONG !! Please try a number between 0 and 25 :");
                    x = Convert.ToDouble(Console.ReadLine());
                }
            }
            //choosing operator
            Console.WriteLine("Please choose operator \"*\" OR \"/\" :");
            string ope = Console.ReadLine();
            while (ope != "*" & ope != "/")
            {
                if (ope != "*" | ope != "/")
                {
                    Console.WriteLine("WRONG !! Please choose operator \"*\" OR \"/\" :");
                    ope = Console.ReadLine();
                }
            }


            double mul ;//this variable is for calculating the power of x
            double result = 0;//this variable is to store the result of operation in numerator
            double final_result = 0;// this variable will store the final result of summing 30 terms
            for (int i = 1; i <= 30; i++)//this loop for the 30 term that we want to calculate
            {
                double fact = 1;// this variable to calculate factorial
                double min;// this will store the minimum value
                 mul = 1;
                //finds the power 
                 for (int j = 0; j <3*i-1; j ++)
                 {
                      mul *= x;
                 }
                 //finds the factorial
                for (int k = 1; k <=2*i+2; k++)
                {
                    fact *= k;
                }
                //finds minimum
                double a = fact;
                double b = mul * (4 * i - 1);

                if (a < b)
                    min = a;
                else
                    min = b;
                //determines whether operator / or * and performs the operation
                if (ope == "*")
                {
                     result = min*(5*i-3);
                }else if (ope == "/")
                {
                    result = min / (5 * i - 3);
                }
                //calculating the operations in denominator 
                double result_deno = 0;
                for (int k = 2 * (i - 1) + 2; k <= i * 4; k += 2)
                {
                    double numbers_sum = 0;//sum of numbers in denominator.
                    double mul2 = 1;
                    for (int n = 0; n <= i; n++)// this loop to calculate power 
                    {
                        mul2 *= k;
                    }
                    numbers_sum += mul2;
                    result_deno += numbers_sum;//the final result of denominator
                }
                //result of each term
                double term_result = result / result_deno;
                if (i % 2 == 0)
                {
                    term_result = term_result * -1;
                }
                final_result += term_result;

            }
            //the final result of the 30 terms
            Console.WriteLine("--------------------------------------------");

            Console.Write("The result of entered values is : "+final_result);
            Console.WriteLine();

        }
    }
}
