using Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept;

class Movement
{
    public Movement(string organ)
    {
        if(organ == "Leg")
        {
            Leg leg = new Leg("Legs");
            leg.Walk();
        }
        else
        {
            Hand hand = new Hand("Hands");
            hand.Move();
        }
    }    
}

class Leg : Organ
{
    public Leg(string name) : base(name)
    {
    }

    public void Walk()
    {
        Console.WriteLine("The legs are walking");
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} moves and walks");
    }
}

class Hand : Organ
{
    public Hand(string name) : base(name)
    {
    }

    public void Move()
    {
        Console.WriteLine("The Hnad is moving something");
    }

    public override void Function()
    {
        Console.WriteLine($"The {Name} motions and holds things");
    }
}
