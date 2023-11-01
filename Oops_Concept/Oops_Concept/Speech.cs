using Human;
using Oops_Concept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept;

class Speech
{
    public Speech(string gender)
    {
        AdamsApple adamsApple = new AdamsApple();

        if (gender == "Male")
        {
            adamsApple.MaleVoice();
        }
        else
        {
            adamsApple.FemaleVoice();
        }
    }
}

class Lungs : Organ
{
    public Lungs(string name) : base(name)
    {
    }

    public static void AirFlow()
    {
        Console.WriteLine("The air is flowing through the lungs and back out");
        Larynx.VocalCords();
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} is responsible for breathing and respiration");
    }
}

class Windpipe
{
    public static void CarryAir()
    {
        Console.WriteLine("Carrying the air to the lungs");
        Lungs.AirFlow();
    }
}

class Larynx : Organ
{
    public Larynx(string name) : base(name)
    {
    }

    public static void VocalCords()
    {
        Console.WriteLine("Vocal Cords are vibrating and voice is forming");
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} is responsible for containing and protecting Vocal Cords");
    }
}

class AdamsApple
{
    public void MaleVoice()
    {
        Console.WriteLine("Prominent Adam's Apple, low pitch voice");
        Windpipe.CarryAir();
    }

    public void FemaleVoice()
    {
        Console.WriteLine("Minute Adam's Apple, heavy pitch voice");
        Windpipe.CarryAir();
    }
}