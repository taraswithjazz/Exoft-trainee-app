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

        public UnitOfWork(GmfctnContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
