namespace Human;

class DigestiveSystem
{
    public static void DigestFood(string food)
    {
        Console.WriteLine("The digestive system begins digesting food.");
        Stomach.ProcessFood(food);
    }
}

class Mouth : Organ
{
    public Mouth(string name) : base(name)
    {
    }

    public void ChewFood(string food)
    {
        Console.WriteLine("The mouth chews the food.");
        DigestiveSystem.DigestFood(food);
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} eats and talks");
    }
}

class Stomach : Organ
{
    public Stomach(string name) : base(name)
    {
    }

    public static void ProcessFood(string food)
    {
        Console.WriteLine("The stomach is breaking down the food.");
        SmallIntestine.AbsorbNutrients();
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} processes food");
    }
}

class SmallIntestine : Organ
{
    public SmallIntestine(string name) : base(name)
    {
    }

    public static void AbsorbNutrients()
    {
        Console.WriteLine("The small intestine absorbs nutrients from the digested food.");
        LargeIntestine.ProcessWaste();
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} absorbs nutirents");
    }
}

class LargeIntestine : Organ
{
    public LargeIntestine(string name) : base(name)
    {
    }

    public static void ProcessWaste()
    {
        Console.WriteLine("The large intestine processes waste and prepares it for elimination.");
        Console.WriteLine("The digestion process is complete.");
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} processes waste");
    }
}
