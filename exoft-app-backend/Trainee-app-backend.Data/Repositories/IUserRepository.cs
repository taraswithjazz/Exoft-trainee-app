using System;
using System.Collections.Generic;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsersFull();
        public IEnumerable<User> GetAllUsersShort();
        public User GetUserById(Guid id);
        public void CreateUser(UserCreateDTO userCreateDTO);
        public void UpdateUser(Guid id, UserUpdateDTO userUpdateDTO);
        public void DeleteUser(Guid id);
    }
}
