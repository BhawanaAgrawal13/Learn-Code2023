using Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    public class Female : IBody
    {
        public void Eat(string food)
        {
            Mouth mouth = new Mouth("Mouth");
            mouth.ChewFood(food);
        }

        public void Locomotion(string organ)
        {
            Movement movement = new Movement(organ);
        }

        public void Speak()
        {
            Speech speech = new Speech("Female");
        }

        public void ThoughtProcess()
        {
            Brain.Recognize("A Purse");
        }

        public void View(string thing)
        {
            HumanEye eye = new HumanEye("Human Eye");
            eye.SeeSomething(thing);
        }
    }
}
