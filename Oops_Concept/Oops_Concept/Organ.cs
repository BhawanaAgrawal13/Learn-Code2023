namespace Human
{
    abstract class Organ
    {
        public string Name { get; set; }

        public Organ(string name)
        {
            Name = name;
        }

        public abstract void Function();
    }
}
