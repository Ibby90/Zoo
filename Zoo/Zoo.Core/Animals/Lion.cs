namespace Zoo.Core.Animals
{
    // Define a class Lion that inherits from the Animal class
    public class Lion : Animal
    {
        // Define a constructor for the Lion class
        public Lion(string name, int age, bool isHungry, bool isActive, int mood, string moodDescription, string race, string origin, string size, FoodStorage foodStorage)
            // Call the base constructor with the provided values and the foodStorage instance
            : base(name, age, isHungry, isActive, mood, moodDescription, race, origin, size, foodStorage) { }

        // Override the FavoriteFood property to return "Meat"
        public override string FavoriteFood => "Meat";

        // Override the BestActivity property to return "Roaming"
        public override string BestActivity => "Roaming";

        // Override the Sound property to return "Roar"
        public override string Sound => "Roar";

        // Override the MakeSound method to print a message
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: {Sound}!");
        }
    }
}
