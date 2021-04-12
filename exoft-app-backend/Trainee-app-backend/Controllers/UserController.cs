using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Trainee_app_backend.Data;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;
using Trainee_app_backend.Data.Repositories;
using Trainee_app_backend.Data.Services;

namespace Trainee_app_backend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllUsersAsync(cancellationToken);

            if (users == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(users);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUserByIdAsync(id, cancellationToken);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateDTO userCreateDTO, CancellationToken cancellationToken)
        {
            var user = await _userService.CreateUserAsync(userCreateDTO, cancellationToken);

            return Ok(user);
        }


        [HttpPost("edit")]
        public async Task<IActionResult> UpdateUser(Guid id, UserUpdateDTO userUpdateDTO, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUserByIdAsync(id, cancellationToken);

            return Ok(user);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid id, CancellationToken cancellationToken)
        {
            await _userService.DeleteUserAsync(id, cancellationToken);

            return Ok(NoContent());
        }
    }
}
