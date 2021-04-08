using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GmfctnContext _context;
        private readonly IMapper _mapper;
        public UserRepository(GmfctnContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAllUsersFull()
        {
            return _context.Users;
        }

        public IEnumerable<User> GetAllUsersShort()
        {
            return _context.Users;
        }

        public User GetUserById(Guid id)
        {
            return _context.Users.FirstOrDefault(e => e.Id == id);

        }

        public void CreateUser(UserCreateDTO userCreateDTO)
        {
            User userEntity = _mapper.Map<User>(userCreateDTO);
            _context.Users.Add(userEntity);
            _context.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
            _context.SaveChanges();
        }


        public void UpdateUser(Guid id, UserUpdateDTO userUpdateDTO)
        {
            User userEntity = GetUserById(id);
            userEntity.FirstName = userUpdateDTO.FirstName;
            userEntity.LastName = userUpdateDTO.LastName;
            userEntity.Email = userUpdateDTO.Email;
            userEntity.Status = userUpdateDTO.Status;
            userEntity.Roles = userUpdateDTO.Roles;
            userEntity.UserName = userUpdateDTO.UserName;

            _context.SaveChanges();
        }
    }
}