namespace Zoo.Core.Animals;

public class FoodStorage
{
    // Define a dictionary to store the amount of each type of food
    private Dictionary<string, int> storage;

    // Define a constructor for the FoodStorage class
    public FoodStorage()
    {
        // Initialize the storage with 100 units of each type of food
        storage = new Dictionary<string, int>
        {
            { "Meat", 100 }, // For Lion, Wolf
            { "Leaves", 100 }, // For Giraffe
            { "Bananas", 100 }, // For Monkey
            { "Fish", 100 } // For PolarBear
        };
    }

    // Define a method to check if there's enough food of a certain type
    public bool CheckFoodAvailability(string food, int amount)
    {
        // There's enough food if the storage contains the food and the amount of the food is greater than or equal to the required amount
        return storage.ContainsKey(food) && storage[food] >= amount;
    }

    // Define a method to use a certain amount of food
    public void UseFood(string food, int amount)
    {
        // If the storage contains the food and the amount of the food is greater than or equal to the required amount, decrease the amount of the food
        if (storage.ContainsKey(food) && storage[food] >= amount)
        {
            storage[food] -= amount;
        }
        else
        {
            // If there's not enough food in the storage, print a message indicating so
            Console.WriteLine($"Not enough {food} in storage.");
        }
    }



public void AddFood(string food, int amount)
    {
        if (storage.ContainsKey(food))
        {
            storage[food] += amount;
        }
        else
        {
            Console.WriteLine($"No storage found for {food}.");
        }
    }

}
