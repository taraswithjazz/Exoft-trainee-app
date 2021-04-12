﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public GmfctnContext _context;
        public DbSet<User> DbSet;

        public UserRepository(GmfctnContext context)
        {
            _context = context;
            DbSet = context.Set<User>();

        }

        public async Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().ToListAsync<User>(cancellationToken);
        }

        public async Task<User> GetUserById(Guid Id, CancellationToken cancellationToken)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(Item => Item.Id == Id, cancellationToken);
        }

        public async Task CreateUser(User user, CancellationToken cancellationToken)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            await DbSet.AddAsync(user, cancellationToken);
        }

        public async Task DeleteUser(Guid id, CancellationToken cancellationToken)
        {
            var user = await DbSet.FirstOrDefaultAsync(Item => Item.Id == id, cancellationToken);
            if (user == null)
            {
                throw new ArgumentException(nameof(id));
            }
            DbSet.Remove(user);
        }

        public void UpdateUser(User user)
        {
            DbSet.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}