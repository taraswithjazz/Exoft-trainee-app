using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsersAsync(CancellationToken cancellationToken);
        public Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
        public Task CreateUserAsync(User achievement, CancellationToken cancellationToken);
        public Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
        public void UpdateUser(User achievement);
    }
}
