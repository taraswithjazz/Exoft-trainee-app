using System;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.Entities;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GmfctnContext _context;
        private GenericRepository<Achievement> _AchievementRepository;
        private GenericRepository<User> _UserRepository;

        public UnitOfWork(GmfctnContext context)
        {
            this._context = context;
        }

        public GenericRepository<Achievement> AchievementRepository
        {
            get
            {
                if (_AchievementRepository == null)
                {
                    _AchievementRepository = new GenericRepository<Achievement>(_context);
                }
                return _AchievementRepository;
            }
        }
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (_UserRepository == null)
                {
                    _UserRepository = new GenericRepository<User>(_context);
                }
                return _UserRepository;
            }
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
