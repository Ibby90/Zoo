using Zoo.Core.Animals;

namespace Zoo.Core.UseCases;

public class StorageManagement
{
    public void RefillStorage(FoodStorage foodStorage)
    {
        Console.WriteLine("What type of food do you want to add?");
        Console.WriteLine("1. Meat");
        Console.WriteLine("2. Leaves");
        Console.WriteLine("3. Bananas");
        Console.WriteLine("4. Fish");

        int foodType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How much food do you want to add?");
        Console.WriteLine("1. 10");
        Console.WriteLine("2. 20");
        Console.WriteLine("3. 40");
        Console.WriteLine("4. 60");
        Console.WriteLine("5. 80");

        int amountOption = Convert.ToInt32(Console.ReadLine());

        int amount;
        switch (amountOption)
        {
            case 1:
                amount = 10;
                break;
            case 2:
                amount = 20;
                break;
            case 3:
                amount = 40;
                break;
            case 4:
                amount = 60;
                break;
            case 5:
                amount = 80;
                break;
            default:
                Console.WriteLine("Invalid amount option.");
                return;
        }

        switch (foodType)
        {
            case 1:
                foodStorage.AddFood("Meat", amount);
                break;
            case 2:
                foodStorage.AddFood("Leaves", amount);
                break;
            case 3:
                foodStorage.AddFood("Bananas", amount);
                break;
            case 4:
                foodStorage.AddFood("Fish", amount);
                break;
            default:
                Console.WriteLine("Invalid food type.");
                break;
        }
    }
}
