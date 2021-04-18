using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllUsersAsync(CancellationToken cancellationToken);
        public Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken);
        public Task<User> CreateUserAsync(UserCreateDTO user, CancellationToken cancellationToken);
        public Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
        public Task<User> UpdateUserAsync(Guid id, UserUpdateDTO user, CancellationToken cancellationToken);
    }
}
