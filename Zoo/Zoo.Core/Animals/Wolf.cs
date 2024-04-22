namespace Zoo.Core.Animals
{
    public class Wolf : Animal
    {
        public Wolf(string name, int age, bool isHungry, bool isActive, int mood, string moodDescription, string race, string origin)
            : base(name, age, isHungry, isActive, mood, moodDescription, race, origin) { }

        public override string FavoriteFood => "Meat";
        public override string BestActivity => "Hunting";
        public override string Sound => "Howl";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: {Sound}!");
        }
    }
}

