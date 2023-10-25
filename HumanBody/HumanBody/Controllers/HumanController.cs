using HumanBody.Repositories;
using HumanBody.Services;
using Microsoft.AspNetCore.Mvc;

namespace HumanBody.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HumanController : Controller
    {
        private readonly IEat _eat;
        private readonly IMovementRepository _movementRepository;

        public HumanController(IEat eat, IMovementRepository movementRepository)
        {
            _movementRepository = movementRepository;
            _eat = eat;
        }

        [HttpGet]
        public string Eat()
        {
            return _eat.EatFood();
        }

        [HttpGet]
        public string MoveHand()
        {
            Movement movement = new Hand(_movementRepository);
            return movement.Move();
        }

        [HttpGet]
        public string MoveLeg()
        {
            Movement movement = new Leg(_movementRepository);
            return movement.Move();
        }
    }
}
