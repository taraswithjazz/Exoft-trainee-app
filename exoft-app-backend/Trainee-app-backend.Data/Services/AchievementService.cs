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
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AchievementService(IAchievementRepository achievementRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _achievementRepository = achievementRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Achievement>> GetAllAchievementsAsync(CancellationToken cancellationToken)
        {
            var achievements = await _achievementRepository.GetAllAchievementsAsync(cancellationToken);

            return achievements;
        }

        public async Task<Achievement> GetAchievementByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var achievement = await _achievementRepository.GetAchievementByIdAsync(id, cancellationToken);

            return achievement;
        }

        public async Task<Achievement> CreateAchievementAsync(AchievementCreateDTO achievementCreateDTO, CancellationToken cancellationToken)
        {
            var achievement = _mapper.Map<Achievement>(achievementCreateDTO);
            await _achievementRepository.CreateAchievementAsync(achievement, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return achievement;
        }

        public async Task<Achievement> UpdateAchievementAsync(Guid id, AchievementUpdateDTO achievementUpdateDTO, CancellationToken cancellationToken)
        {
            var achievement = await _achievementRepository.GetAchievementByIdAsync(id, cancellationToken);
            _mapper.Map(achievementUpdateDTO, achievement);
            _achievementRepository.UpdateAchievement(achievement);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return achievement;
        }

        public async Task DeleteAchievementAsync(Guid id, CancellationToken cancellationToken)
        {
            await _achievementRepository.DeleteAchievementAsync(id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
