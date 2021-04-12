using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraineeAppBackend.Data.Entities;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Repositories;
using Trainee_app_backend.Data;
using AutoMapper;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data.Services;

namespace TraineeAppBackend.Controllers
{
    [Route("api/achievements")]
    [ApiController]
    public class AchievementController : Controller
    {
        private readonly IAchievementService _achievementService;

        public AchievementController(IAchievementService achievementService)
        {
            _achievementService = achievementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAchievements(CancellationToken cancellationToken)
        {
            var achievements = await _achievementService.GetAllAchievements(cancellationToken);

            if (achievements == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(achievements);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAchievementById(Guid id, CancellationToken cancellationToken)
        {
            var achievement = await _achievementService.GetAchievementById(id, cancellationToken);

            if (achievement == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(achievement);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAchievement(AchievementCreateDTO achievementCreateDTO, CancellationToken cancellationToken)
        {
            var achievement = await _achievementService.CreateAchievement(achievementCreateDTO, cancellationToken);

            return Ok(achievement);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> UpdateAchievement(Guid id, AchievementUpdateDTO achievementUpdateDTO, CancellationToken cancellationToken)
        {
            var achievement = await _achievementService.UpdateAchievement(id, achievementUpdateDTO, cancellationToken);

            return Ok(achievement);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAchievement(Guid id, CancellationToken cancellationToken)
        {
            await _achievementService.DeleteAchievement(id, cancellationToken);

            return Ok(NoContent());
        }
    }
}