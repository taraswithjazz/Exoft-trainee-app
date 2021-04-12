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

        public async Task<IEnumerable<Achievement>> GetAllAchievements(CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().ToListAsync<Achievement>(cancellationToken);
        }

        public async Task<Achievement> GetAchievementById(Guid Id, CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(Item => Item.Id == Id, cancellationToken);
        }

        public async Task CreateAchievement(Achievement achievement, CancellationToken cancellationToken)
        {
            if (achievement == null)
            {
                throw new ArgumentNullException(nameof(achievement));
            }
            await DbSet.AddAsync(achievement, cancellationToken);
        }

        public async Task DeleteAchievement(Guid id, CancellationToken cancellationToken)
        {
            var element = await DbSet.FirstOrDefaultAsync(Item => Item.Id == id, cancellationToken);
            if (element == null)
            {
                throw new ArgumentException(nameof(id));
            }
            DbSet.Remove(element);
        }

        public void UpdateAchievement(Achievement achievement)
        {
            DbSet.Attach(achievement);
            _context.Entry(achievement).State = EntityState.Modified;
        }
    }
}
