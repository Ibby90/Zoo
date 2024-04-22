

namespace Zoo.Core.Animals;

    // Define an abstract class Animal
    public abstract class Animal
    {
        // Define a constant for the standard mood value
        protected const int StandardMood = 50;

        // Define properties for the animal's name, age, hunger status, activity status, mood, mood description, visitor fitness, race, origin, health, and energy
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsHungry { get; private set; }
        public bool IsActive { get; private set; }
        public int Mood { get; private set; }
        public string MoodDescription { get; private set; }
        public bool IsFitForVisitor { get; private set; }
        public string Race { get; private set; }
        public string Origin { get; private set; }
        public int Health { get; private set; }
        public int Energy { get; private set; }
        public string Size { get; private set; } // New Size property
        protected FoodStorage FoodStorage { get; set; } // New FoodStorage property

        // Define a constructor for the Animal class
        protected Animal(string name, int age, bool isHungry, bool isActive, int mood, string moodDescription, string race, string origin, string size, FoodStorage foodStorage)
        {
            // Initialize properties with the provided values
            Name = name;
            Age = age;
            IsHungry = isHungry;
            IsActive = isActive;
            Mood = mood;
            MoodDescription = moodDescription;
            Race = race;
            Origin = origin;
            Size = size; // Initialize the Size property
            FoodStorage = foodStorage; // Initialize the FoodStorage property
            // Check if the animal is fit for visitors
            IsFitForVisitor = CheckIfFitForVisitor();
            // Initialize health and energy to 100
            Health = 100; // Assuming health is on a scale of 0-100
            Energy = 100; // Assuming energy is on a scale of 0-100
        }

        // Define abstract properties for the animal's sound, favorite food, and best activity
        public abstract string Sound { get; }
        public abstract void MakeSound();
        public abstract string FavoriteFood { get; }
        public abstract string BestActivity { get; }

        // Define a method to check if the animal is fit for visitors
        private bool CheckIfFitForVisitor()
        {
            // The animal is fit for visitors if its mood is greater than or equal to the standard mood
            return Mood >= StandardMood;
        }

        // Define a method to check the animal's mood
        public void CheckMood()
        {
            // If the mood is 0, print a message indicating urgent attention is needed
            if (Mood == 0)
            {
                Console.WriteLine("You need to attend to this animal Azap!!");
            }
            // If the mood is greater than the standard mood, print a message to check on the animal
            else if (Mood > StandardMood)
            {
                Console.WriteLine($"Check on {Name}");
            }
        }


        // Define a method to feed the animal
        public void Feed(string food)
        {
            // Determine the amount of food based on the size of the animal
            int amountToFeed = Size == "Large" ? 3 : Size == "Medium" ? 2 : 1;

            // Check if there's enough food in the storage
            if (FoodStorage.CheckFoodAvailability(food, amountToFeed))
            {
                // If the food is the animal's favorite, increase its mood and health
                if (food == FavoriteFood)
                {
                    Mood += 2;
                    Health += 10;
                }
                // If the food is not the animal's favorite but it's not wrong food, slightly increase its mood and health
                else if (food != FavoriteFood && food != "Wrong food")
                {
                    Mood += 1;
                    Health += 5;
                }
                // If the food is wrong for the animal, print a message indicating so
                else if (food == "Wrong food")
                {
                    Console.WriteLine("This food is not suitable for this animal.");
                }

                // Use the food from the storage
                FoodStorage.UseFood(food, amountToFeed);

                // Ensure the mood does not exceed 10
                Mood = Math.Min(Mood, 10);

                // Update the animal's fitness for visitors
                IsFitForVisitor = CheckIfFitForVisitor();
            }
            else
            {
                // If there's not enough food in the storage, print a message indicating so
                Console.WriteLine("Not enough food in the storage.");
            }
        }

        // Define a method for the animal to do its favorite activity
        public void DoActivity()
        {
            // Print a message indicating the animal is doing its favorite activity
            Console.WriteLine($"{Name} is now {BestActivity}.");
            // Increase the animal's mood, set it to hungry and active, and decrease its energy
            Mood += 1;
            IsHungry = true;
            IsActive = true;
            Energy -= 10;

            // Ensure the mood does not exceed 10
            Mood = Math.Min(Mood, 10);

            // Update the animal's fitness for visitors
            IsFitForVisitor = CheckIfFitForVisitor();
        }

        // Define a method for the animal to sleep
        public void Sleep()
        {
            // Print a message indicating the animal is sleeping
            Console.WriteLine($"{Name} is now sleeping.");
            // Set the animal to inactive, increase its mood and energy
            IsActive = false;
            Mood += 1;
            Energy += 20;

            // Ensure the mood does not exceed 10
            Mood = Math.Min(Mood, 10);

            // Update the animal's fitness for visitors
            IsFitForVisitor = CheckIfFitForVisitor();
        }
    }

