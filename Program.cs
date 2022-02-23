using System;

namespace MilkTotalsApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter milk to be added in ounces");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter milk to be added in ounces 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}",num1,num2,result);

            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();

            Console.WriteLine("Hello World")
        }
    }
}