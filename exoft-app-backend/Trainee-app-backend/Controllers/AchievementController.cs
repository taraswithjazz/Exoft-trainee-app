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

namespace TraineeAppBackend.Controllers
{
    [Route("api/achievements")]
    [ApiController]
    public class AchievementController : Controller
    {
        private IUnitOfWork UnitOfWork;
        private readonly IMapper _mapper;

        public AchievementController(GmfctnContext context, IMapper mapper)
        {
            UnitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAchievements(CancellationToken cancellationToken)
        {
            var achievements = await UnitOfWork.AchievementRepository.GetAll(cancellationToken);
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
            var achievement = await UnitOfWork.AchievementRepository.GetById(id, cancellationToken);
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

            var achievement = _mapper.Map<Achievement>(achievementCreateDTO);
            achievement.Id = new Guid();
            await UnitOfWork.AchievementRepository.Create(achievement, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Ok(achievement);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> UpdateAchievement(Guid id, AchievementUpdateDTO achievementUpdateDTO, CancellationToken cancellationToken)
        {
            var achievement = await UnitOfWork.AchievementRepository.DbSet.FirstOrDefaultAsync(item => item.Id == id);
            _mapper.Map(achievementUpdateDTO, achievement);
            UnitOfWork.AchievementRepository.Update(achievement);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Ok(achievement);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAchievement(Guid id, CancellationToken cancellationToken)
        {
            await UnitOfWork.AchievementRepository.Delete(id, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Ok(NoContent());
        }
    }
}