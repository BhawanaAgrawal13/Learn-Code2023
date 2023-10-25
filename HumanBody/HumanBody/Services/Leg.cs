using HumanBody.Repositories;

namespace HumanBody.Services
{
    public class Leg : Movement
    {
        private readonly IMovementRepository _movementRepository;
        public Leg(IMovementRepository movementRepository) : base(movementRepository)
        {
            _movementRepository = movementRepository;
        }

        public override string Move()
        {
            return "Legs: " + _movementRepository.MoveBody();
        }
    }
}
