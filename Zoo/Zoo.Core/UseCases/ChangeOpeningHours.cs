namespace Zoo.Core.UseCases;

public class ChangeOpeningHours
{
    private readonly ZooContext _zoo;

    public ChangeOpeningHours(ZooContext zoo)
    {
        _zoo = zoo;
    }

    public void Handle(Hours hours)
    {
        _zoo.OpeningHours = hours;
    }
}


