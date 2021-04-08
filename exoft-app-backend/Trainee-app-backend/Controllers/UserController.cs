using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;
using Trainee_app_backend.Data.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trainee_app_backend.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _repository.GetAllUsersFull();
            return Ok(users);
        }

        [HttpGet("info")]
        public IActionResult GetAllUsersInfo()
        {
            var usersInfo = _mapper.Map<IEnumerable<UserInfoDTO>>(_repository.GetAllUsersShort());
            return Ok(usersInfo);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            var user = _mapper.Map<UserInfoDTO>(_repository.GetUserById(id));
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(UserCreateDTO userCreateDTO)
        {
            try
            {
                _repository.CreateUser(userCreateDTO);
                return Ok(_repository.GetAllUsersFull());
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }


        [HttpPost("edit")]
        public IActionResult UpdateUser(Guid id, UserUpdateDTO userUpdateDTO)
        {
            try
            {
                _repository.UpdateUser(id, userUpdateDTO);
                return Ok(_repository.GetAllUsersFull());
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteUser(Guid id)
        {
            _repository.DeleteUser(id);
            return Ok(_repository.GetAllUsersFull());
        }
    }
}
