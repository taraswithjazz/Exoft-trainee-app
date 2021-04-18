using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        public GmfctnContext _context;
        public DbSet<Achievement> DbSet;

        public AchievementRepository(GmfctnContext context)
        {
            _context = context;
            DbSet = context.Set<Achievement>();

        }

        public async Task<IEnumerable<Achievement>> GetAllAchievementsAsync(CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().ToListAsync<Achievement>(cancellationToken);
        }

        public async Task<Achievement> GetAchievementByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(item => item.Id == id, cancellationToken);
        }

        public async Task CreateAchievementAsync(Achievement achievement, CancellationToken cancellationToken)
        {
            if (achievement == null)
            {
                throw new ArgumentNullException(nameof(achievement));
            }

            await DbSet.AddAsync(achievement, cancellationToken);
        }

        public async Task DeleteAchievementAsync(Guid id, CancellationToken cancellationToken)
        {
            var achievement = await DbSet.FirstOrDefaultAsync(item => item.Id == id, cancellationToken);
            if (achievement == null)
            {
                throw new ArgumentException(nameof(id));
            }

            DbSet.Remove(achievement);
        }

        public void UpdateAchievement(Achievement achievement)
        {
            DbSet.Attach(achievement);
            _context.Entry(achievement).State = EntityState.Modified;
        }
    }
}
