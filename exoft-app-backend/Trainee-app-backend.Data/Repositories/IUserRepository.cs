using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken);
        public Task<User> GetUserById(Guid id, CancellationToken cancellationToken);
        public Task CreateUser(User achievement, CancellationToken cancellationToken);
        public Task DeleteUser(Guid id, CancellationToken cancellationToken);
        public void UpdateUser(User achievement);
    }
}
