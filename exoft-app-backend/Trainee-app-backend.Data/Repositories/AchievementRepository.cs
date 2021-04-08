using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data;
using Trainee_app_backend.Data.DTOs;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private readonly GmfctnContext _context;
        private readonly IMapper _mapper;
        public AchievementRepository(GmfctnContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Achievement> GetAllAchievements()
        {
            return _context.Achievements;
        }

        public Achievement GetAchievementById(Guid id)
        {
            return _context.Achievements.FirstOrDefault(e => e.Id == id);
        }

        public void CreateAchievement(AchievementCreateDTO achievementCreateDTO)
        {
            Achievement userEntity = _mapper.Map<Achievement>(achievementCreateDTO);
            _context.Achievements.Add(userEntity);
            _context.SaveChanges();
        }
        public void UpdateAchievement(Guid id, AchievementUpdateDTO achievementUpdateDTO)
        {
            var achievementFound = GetAchievementById(id);
            achievementFound.Name = achievementUpdateDTO.Name;
            achievementFound.Description = achievementUpdateDTO.Description;
            achievementFound.Xp = achievementUpdateDTO.Xp;

            _context.SaveChanges();
        }
        public void DeleteAchievement(Guid id)
        {
            var achievement = _context.Achievements.Find(id);
            if (achievement != null)
            {
                _context.Achievements.Remove(achievement);
            }
            _context.SaveChanges();
        }
    }
}
