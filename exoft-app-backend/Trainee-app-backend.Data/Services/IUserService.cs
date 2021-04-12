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
        public Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken);
        public Task<User> GetUserById(Guid id, CancellationToken cancellationToken);
        public Task<User> CreateUser(UserCreateDTO achievement, CancellationToken cancellationToken);
        public Task DeleteUser(Guid id, CancellationToken cancellationToken);
        public Task<User> UpdateUser(Guid id, UserUpdateDTO achievement, CancellationToken cancellationToken);
    }
}
