using Oops_Concept;

namespace Human;
class Program
{
    static void Main()
    {
        Console.WriteLine("\nHuman Male");
        
        Male male = new Male();
        Console.WriteLine("\nMOVING A LEG");
        male.Locomotion("Leg");
        Console.WriteLine("\nEATING A SANDWICH");
        male.Eat("A Sandwich");
        Console.WriteLine("\nTHINKING");
        male.ThoughtProcess();
        Console.WriteLine("\nSEEING A DOG");
        male.View("A Dog");
        Console.WriteLine("\nSPEAKING");
        male.Speak();

        Console.WriteLine("\n------------------------------------------\n");
        Console.WriteLine("Human Female");

        Female female = new Female();
        Console.WriteLine("\nMOVING A HAND");
        female.Locomotion("Hand");
        Console.WriteLine("\nEATING A PIZZA");
        female.Eat("A Pizza");
        Console.WriteLine("\nTHINKING");
        female.ThoughtProcess();
        Console.WriteLine("\nSEEING A CAT"); 
        female.View("A Cat");
        Console.WriteLine("\nSPEAKING");
        female.Speak();

        Console.ReadLine();
    }
}
