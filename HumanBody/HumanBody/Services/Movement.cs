using HumanBody.Repositories;

namespace HumanBody.Services
{
    public class Movement
    {
        private readonly IMovementRepository _movementRepository;
        public Movement(IMovementRepository movementRepository)
        {
            _movementRepository = movementRepository;
        }

        public virtual string Move()
        {
            return _movementRepository.MoveBody();
        }
    }
}
