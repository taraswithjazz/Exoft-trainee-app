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
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUsersAsync(cancellationToken);

            return users;
        }

        public async Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(id, cancellationToken);

            return user;
        }

        public async Task<User> CreateUserAsync(UserCreateDTO userCreateDTO, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(userCreateDTO);
            await _userRepository.CreateUserAsync(user, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async Task<User> UpdateUserAsync(Guid id, UserUpdateDTO userUpdateDTO, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByIdAsync(id, cancellationToken);
            _mapper.Map(userUpdateDTO, user);
            _userRepository.UpdateUser(user);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }

        public async Task DeleteUserAsync(Guid id, CancellationToken cancellationToken)
        {
            await _userRepository.DeleteUserAsync(id, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
