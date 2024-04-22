using Zoo.Core.Animals;

namespace Zoo.Core.UseCases;

public class AddAnimal
{
    private readonly ZooContext _zoo;

    public AddAnimal(ZooContext zoo)
    {
        _zoo = zoo;
    }

    public AddAnimalResponse Handle(Animal animal)
    {
        if (!CanAddAnimal())
            return new AddAnimalResponse(false, "Too many animals already");

        _zoo.Animals.Add(animal);
        return new AddAnimalResponse(true, "Animal added");
    }

    private bool CanAddAnimal()
    {
        return _zoo.Animals.Count < 10; 
    }
}

public record AddAnimalResponse(bool Success, string Message= "");