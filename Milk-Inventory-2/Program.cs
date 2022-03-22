using System.Text.Json;

namespace MilkInventory2
{
    class Program
    {
        static void Main()
        {
            //START JSON
            var fileName = "MilkInventory.json";

            var milkInventory = new MilkInventory();

            if (File.Exists(fileName))
            {
                var fileText = File.ReadAllText(fileName);
                var mightbeMilkInventory = JsonSerializer.Deserialize<MilkInventory>(fileText);

                if (mightbeMilkInventory != null);
                {
                    milkInventory = mightbeMilkInventory;
                }

            }
            
            //int amt = 7773;
            //int dep, wit;
            //int ch, pin = 0, x=0;
            //Console.WriteLine("Who are we feeding today?");
            //pin = int.Parse(Console.ReadLine());
            ////IDEA: remove name

             
            Console.Clear();
            Console.Title = "Milk Inventory System";
            //Console.WriteLine("Welcome to your milk tracking system.\n");
            //Console.WriteLine("MORE TEXT HERE.");

            //work on var keep going -- in while statement ex: while keep going initialize to true.  Exit cmd is set to false
            var keepGoing = true;
            
            while (keepGoing)
            {
                Console.WriteLine("\nMilk Inventory");
                Console.WriteLine("====================\n");
                Console.WriteLine("1. Check my Inventory");
                Console.WriteLine("2. Enter a feeding (in mL)");
                Console.WriteLine("3. Add to freezer (in mL)");
                Console.WriteLine("4. Convert my Inventory to ounces");
                Console.WriteLine("5. Exit\n\n\n");
                Console.WriteLine("Select your Option:");
                var command = int.Parse(Console.ReadLine());
                //ch = int.Parse(Console.ReadLine());
                switch (command)
                    //^change ch to command
                {
                    case 1:
                        Console.WriteLine("\n\n Your Milk Inventory is: {MilkInventory.GetInventory()}.");
        
                        break;
                    case 2:
                        Console.WriteLine("How many milliliters of milk were consumed? ");
                        var = amountConsumed = int.Parse(Console.ReadLine());
                        milkinventory.Add(amountConsumed);

                        //wit=int.Parse(Console.ReadLine());
                        //if (wit %100 !=0)
                        //{
                        //    Console.WriteLine("\n\nEnter the amount in Multiples of 100");
                //}
                //        else if (amountConsumed > (milkInventory))
                //{
                //    Console.WriteLine("\n You depleted your inventory.");
                //}
                //else
                //{
                //    amt = amt - wit;
                //    Console.WriteLine("\n You have {0} remaining in inventory",amt);
                //}
                break;

                    case 3:
                        Console.WriteLine("\n How many milliliters of milk are we adding to inventory? ");
                        var amountToAdd = int.Parse(Console.ReadLine());
                        milkinventory.Add(amountToAdd);
                        //    dep=int.Parse(Console.ReadLine());
                        //amt = amt + dep;
                        //Console.WriteLine("\nThis brings your inventory to ______ Current balance is {0}", amt);

                        break;

                    case 4:
                        var inventoryInMilliliters = milkInventory.GetInventoryinMilliliters();
                        var inventoryInOunces = MillilitersToOuncesConverter.ConvertMillilitersToOunces(inventoryInOunces);
                        Console.WriteLine($"\n  Your inventory is {inventoryInOunces} ounces.");
                        //dep = int.Parse(Console.ReadLine());
                        //amt = amt + dep;
                        //Console.WriteLine("\nThis brings your inventory to ______ Current balance is {0}", amt);

                        break;

                    case 5:
                        keepGoing = false;
                        //Console.WriteLine("Press any key to confirm Exit");
                        //Console.ReadKey();
                        //Console.WriteLine("Thank you!");
                        break;


                }

            }

            var jsonString = JsonSerializer.Serialize(milkInventory2);
            File.WriteAllText(fileName, jsonString);

            JsonSerializer.Deserialize(milkInventory2);
            File.WriteAllText(fileName, jsonString);
        }
    }
}