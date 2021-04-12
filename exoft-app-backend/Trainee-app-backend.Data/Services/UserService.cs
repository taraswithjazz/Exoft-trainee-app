using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;
using Trainee_app_backend.Data.Repositories;

namespace Trainee_app_backend.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private IUnitOfWork UnitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, GmfctnContext context, IMapper mapper)
        {
            _userRepository = userRepository;
            UnitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUsers(cancellationToken);

            return users;
        }

        public async Task<User> GetUserById(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserById(id, cancellationToken);

            return user;
        }

        public async Task<User> CreateUser(UserCreateDTO userCreateDTO, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(userCreateDTO);
            await _userRepository.CreateUser(user, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async Task<User> UpdateUser(Guid id, UserUpdateDTO userUpdateDTO, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserById(id, cancellationToken);
            _mapper.Map(userUpdateDTO, user);
            _userRepository.UpdateUser(user);
            await UnitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async Task DeleteUser(Guid id, CancellationToken cancellationToken)
        {
            await _userRepository.DeleteUser(id, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
