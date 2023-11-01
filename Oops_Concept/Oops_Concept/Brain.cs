namespace Human
{
    class Brain : Organ
    {
        public Brain(string name) : base(name)
        {
        }

        public static void Recognize(string thing)
        {
            Console.WriteLine($"The brain recognizes this as '{thing}'.");
        }

        public override void Function()
        {
            Console.WriteLine($"The {Name} is responsible for thought processing.");
            Console.WriteLine("It has cognitive thinking.");
        }
    }

}
