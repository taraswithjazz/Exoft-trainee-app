using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data;
using Trainee_app_backend.Data.DTOs;
using Trainee_app_backend.Data.Entities;
using Trainee_app_backend.Data.Repositories;

namespace Trainee_app_backend.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper _mapper;
        public UserController(GmfctnContext context, IMapper mapper)
        {
            UnitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
        {
            var users = await UnitOfWork.UserRepository.GetAll(cancellationToken);
            if (User == null)
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

            var user = await UnitOfWork.UserRepository.GetById(id, cancellationToken);
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
            var user = _mapper.Map<User>(userCreateDTO);
            await UnitOfWork.UserRepository.Create(user, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Ok(user);
        }


        [HttpPost("edit")]
        public async Task<IActionResult> UpdateUser(Guid id, UserUpdateDTO userUpdateDTO, CancellationToken cancellationToken)
        {
            var user = await UnitOfWork.UserRepository.DbSet.FirstOrDefaultAsync(item => item.Id == id);
            _mapper.Map(userUpdateDTO, user);
            UnitOfWork.UserRepository.Update(user);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Ok(user);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Guid id, CancellationToken cancellationToken)
        {
            await UnitOfWork.UserRepository.Delete(id, cancellationToken);
            await UnitOfWork.SaveChangesAsync(cancellationToken);
            return Ok(NoContent());
        }
    }
}
