using System.Text.Json;

namespace MilkInventory2
{
    class Program
    {
        public static void Main()
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
            
            Console.Clear();
            Console.Title = "Milk Inventory System";
            ////Console.WriteLine("Welcome to your milk tracking system.\n");
            ////Console.WriteLine("MORE TEXT HERE.");


            //BEGIN LOOP
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
                
            //BEGIN CASES
                switch (command)
                {
                    case 1:
                        Console.WriteLine("\n\n Your Milk Inventory is: {MilkInventory.GetInventory()}.");
                        break;

                    case 2:
                        Console.WriteLine("How many milliliters of milk were consumed? ");
                        var amountConsumed = int.Parse(Console.ReadLine());
                        milkinventory.Add(amountConsumed);
                        break;

                    case 3:
                        Console.WriteLine("\n How many milliliters of milk are we adding to inventory? ");
                        var amountToAdd = int.Parse(Console.ReadLine());
                        milkinventory.Add(amountToAdd);
                        break;

                    case 4:
                        var inventoryInMilliliters = milkInventory.GetInventoryinMilliliters();
                        var inventoryInOunces = MillilitersToOuncesConverter.ConvertMillilitersToOunces(inventoryInOunces);
                        Console.WriteLine($"\n  Your inventory is {inventoryInOunces} ounces.");
                        break;

                    case 5:
                        keepGoing = false;
                        Console.WriteLine("Thank you!");
                        break;
                }

            }
            //JSON SERIALIZER
            var jsonString = JsonSerializer.Serialize(milkInventory);
            File.WriteAllText(fileName, jsonString);
        }
    }
}