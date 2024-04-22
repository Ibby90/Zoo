using System;
using Zoo.Core.Animals;

namespace Zoo.Core;

public class ZooContext
{
    public int Price { get; set; }
    public Hours OpeningHours { get; set; }
    public List<Animal> Animals { get; } = new();
}
