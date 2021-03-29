using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trainee_app_backend.Interfaces;
using Trainee_app_backend.Models;
using Trainee_app_backend.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trainee_app_backend.Controllers
{
    [Route("api/achievement")]
    [ApiController]
    public class AchievementController : Controller
    {
        private IAchievementRepository _repository;

        public AchievementController()
        {
            _repository = new AchievementRepository();
        }

        [HttpGet]
        public IEnumerable<Achievement> GetAllAchievements()
        {
            var Achievements = _repository.GetAllAchievements();
            return Achievements;
        }

        [HttpGet("{id}")]
        public Achievement GetAchievementById(int id)
        {
            var Achievement = _repository.GetAchievementById(id);
            return Achievement;
        }
    }
}
