using HumanBody.Repositories;

namespace HumanBody.Services
{
    public class Eat : IEat
    {
        public string EatFood()
        {
            return "The food is eaten\n" + Digest();
        }

        private string Digest()
        {
            return "The food is being digested";
        }
    }
}
