namespace Human
{
    class HumanEye : Organ
    {
        public HumanEye(string name) : base(name) 
        { 
        }

        public override void Function()
        {
            Console.WriteLine($"The {Name} is responsible for vision.");
            Console.WriteLine("It captures and processes images.");
        }

        public void SeeSomething(string thing)
        {
            Console.WriteLine($"The {Name} sees {thing}.");
            SendToBrain(thing);
        }

        private void SendToBrain(string thing)
        {
            Console.WriteLine($"Sending {thing} to the brain for recognition.");
            Brain.Recognize(thing);
        }
    }
}
