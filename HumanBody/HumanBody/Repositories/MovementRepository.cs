namespace HumanBody.Repositories
{
    public class MovementRepository : IMovementRepository
    {
        public MovementRepository() { }

        public string MoveBody()
        {
            return ("Moving the body through repository");
        }
    }
}
