using HumanBody.Repositories;

namespace HumanBody.Services
{
    public class Hand : Movement
    {
        private readonly IMovementRepository _movementRepository;

        public Hand(IMovementRepository movementRepository) : base(movementRepository)
        {
            _movementRepository = movementRepository;
        }

        public override string Move()
        {
           return "Hands: " + _movementRepository.MoveBody();
        }
    }
}
