//using System;

//namespace MilkTotalsApp
//{
//    public static class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1, num2, result;
//            Console.WriteLine("Enter milk to be added in ounces");
//            num1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter milk to be added in ounces 2");
//            num2 = Convert.ToInt32(Console.ReadLine());

//            result = num1 + num2;

//            Console.WriteLine("{0} + {1} = {2}",num1,num2,result);

//            Console.WriteLine("Press any key to Exit");
//            Console.ReadKey();

//            Console.WriteLine("Hello World!!!");
//        }
//    }
//}

////using System;
////public class Exercise7
////{
////    public static void Main()
////    {
////        Console.Write("Enter a number: ");
////        int num1 = Convert.ToInt32(Console.ReadLine());

////        Console.Write("Enter another number: ");
////        int num2 = Convert.ToInt32(Console.ReadLine());

////        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
////        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
////        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
////        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
////        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
////    }
////}

using System;

namespace Sunday6th
{

    class Program
    {
        static void Main(string[] args)
        {
            //milk amount
            //diaper type
            //amount consumed

            var calendar = new Calendar(DateTime.Parse("2022-01-21"));

            Console.WriteLine("For what date would you like to enter data (yyyy-mm-dd)?  Type 'exit' to end task and provide totals.");
            var userInput = Console.ReadLine();

            while (userInput != "exit") {
                var date = DateTime.Parse(userInput);


                int counter;
                Console.WriteLine("How many feedings will you be entering for this date?");
                counter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter amount: ");
                for (int i = 0; i < counter; i++) ;

                Console.WriteLine("");
            }
            
        }

        public class calendar
        {
            public DateTime DateEntered { get; set; }

        }

        public class Milk
        {
            public Int32 MilkChange { get; set; }
            public List<Milk> MilkList { get; set; 
            //milk total equation? 
            //milk type - breast or formula
        }

        public class Diaper
        {
            public enum DiaperType { get; set; }
                public List<DiaperType> DiaperList { get; set; };
                public void DiaperType(string wet, string soiled, string both)
                var DiaperType = new DiaperType();
                Diaper.Type = Wet, Soiled, or Both;

            }
            }

}

    internal class Calendar
    {
        private DateTime dateTime;

        public Calendar(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
    }