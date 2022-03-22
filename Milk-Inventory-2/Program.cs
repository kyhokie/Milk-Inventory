﻿namespace MilkTotalsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIMPLIFY THIS  -- this is where we would put in json
            int amt = 7773;
            int dep, wit;
            int ch, pin = 0, x=0;
            Console.WriteLine("Who are we feeding today?");
            pin = int.Parse(Console.ReadLine());
            //IDEA: remove name

             
            Console.Clear();
            Console.Title = "Milk Tracking System";
            //Console.WriteLine("Welcome to your milk tracking system.\n");
            //Console.WriteLine("MORE TEXT HERE.");

            //work on var keep going -- in while statement ex: while keep going initialize to true.  Exit cmd is set to false
            while (true)
            {
                Console.WriteLine("\nMilk Inventory");
                Console.WriteLine("====================\n");
                Console.WriteLine("1. Check Inventory");
                Console.WriteLine("2. Enter a feeding");
                Console.WriteLine("3. Add to freezer");
                Console.WriteLine("4. Exit\n\n\n");
                Console.WriteLine("Select your Option:");
                ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("\n\n Your Balance is : {0} ",amt);
                        break;
                    case 2:
                        Console.WriteLine("How much was consumed? ");
                        wit=int.Parse(Console.ReadLine());
                        if (wit %100 !=0)
                        {
                            Console.WriteLine("\n\nEnter the amount in Multiples of 100");
                        }
                        else if (wit > (amt - 200))
                        {
                            Console.WriteLine("\n You do not have enough milk in inventory");
                        }
                        else
                        {
                            amt = amt - wit;
                            Console.WriteLine("\n You have {0} remaining in inventory",amt);


                        }

                        break;
                    case 3:
                        Console.WriteLine("\n Enter the amount to be deposited");
                            dep=int.Parse(Console.ReadLine());
                        amt = amt + dep;
                        Console.WriteLine("\nCurrent balance is {0}", amt);

                        break;
                    case 4:
                        Console.WriteLine("Press any key to confirm Exit");
                        Console.ReadKey();
                        Console.WriteLine("Thank you!");

                        break;


                }

            }

            class TestDataModel
        {
            public int val1 { get; set; }
            public string val2 { get; set; }    
        }
        
        }
    }
}