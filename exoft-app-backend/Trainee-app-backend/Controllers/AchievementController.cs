using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraineeAppBackend.Data.Repositories;
using TraineeAppBackend.Data.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TraineeAppBackend.Controllers
{
    [Route("api/achievement")]
    [ApiController]
    public class AchievementController : Controller
    {
        private IAchievementRepository _repository;

        public AchievementController(IAchievementRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllAchievements()
        {
            var achievements = _repository.GetAllAchievements();
            return Ok(achievements);
        }

        [HttpGet("{id}")]
        public IActionResult GetAchievementById(Guid id)
        {
            var achievement = _repository.GetAchievementById(id);
            return Ok(achievement);
        }
    }
}
