using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public class GenericRepository<T> where T : BaseEntity
    {
        public GmfctnContext _context;
        public DbSet<T> DbSet;

        public GenericRepository(GmfctnContext context)
        {
            this._context = context;
            DbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().ToListAsync<T>(cancellationToken);
        }

        public async Task<T> GetById(Guid Id, CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(Item => Item.Id == Id, cancellationToken);
        }

        public async Task Create(T element, CancellationToken cancellationToken)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }
            await DbSet.AddAsync(element, cancellationToken);
        }

        public async Task Delete(Guid Id, CancellationToken cancellationToken)
        {
            var Element = await DbSet.FirstOrDefaultAsync(Item => Item.Id == Id, cancellationToken);
            if (Element == null)
            {
                throw new ArgumentException(nameof(Id));
            }
            DbSet.Remove(Element);
        }

        public void Update(T element)
        {
            DbSet.Attach(element);
            _context.Entry(element).State = EntityState.Modified;
        }
    }
}
