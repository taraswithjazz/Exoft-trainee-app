using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Repositories;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Services
{
    public class AchievementService : IAchievementService
    {
        private readonly IAchievementRepository _achievementRepository;
        private IUnitOfWork UnitOfWork;
        private readonly IMapper _mapper;

        public AchievementService(IAchievementRepository achievementRepository, GmfctnContext context, IMapper mapper)
        {
            _achievementRepository = achievementRepository;
            UnitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }

        public async Task<IEnumerable<Achievement>> GetAllAchievements(CancellationToken cancellationToken)
        {
            var achievements = await _achievementRepository.GetAllAchievements(cancellationToken);

            return achievements;
        }

        public async Task<Achievement> GetAchievementById(Guid id, CancellationToken cancellationToken)
        {
            var achievement = await _achievementRepository.GetAchievementById(id, cancellationToken);

            return achievement;
        }

        public async Task<Achievement> CreateAchievement(AchievementCreateDTO achievementCreateDTO, CancellationToken cancellationToken)
        {
            var achievement = _mapper.Map<Achievement>(achievementCreateDTO);
            //achievement.Id = new Guid();
            await _achievementRepository.CreateAchievement(achievement, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);

            return achievement;
        }

        public async Task<Achievement> UpdateAchievement(Guid id, AchievementUpdateDTO achievementUpdateDTO, CancellationToken cancellationToken)
        {
            var achievement = await _achievementRepository.GetAchievementById(id, cancellationToken);
            _mapper.Map(achievementUpdateDTO, achievement);
            _achievementRepository.UpdateAchievement(achievement);
            await UnitOfWork.SaveChangesAsync(cancellationToken);

            return achievement;
        }

        public async Task DeleteAchievement(Guid id, CancellationToken cancellationToken)
        {
            await _achievementRepository.DeleteAchievement(id, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
