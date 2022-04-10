﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.data;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.Repositories.AkunRepository
{
    public class AkunRepository : IAkunRepository
    {
        private readonly AppDbContext _context;
        public AkunRepository(AppDbContext db)
        {
            _context = db;
        }

        public async Task<List<User>> AmbilSemuaUserAsync()
        {
            return await _context.Tb_User.Include(x => x.Roles).ToListAsync();
        }

        public async Task<User> AmbilUserByUsernameAsync(string username)
        {
            return await _context.Tb_User.FindAsync(username);
        }

        public async Task<User> CariUserAsync(string username)
        {
            return await _context.Tb_User.FirstOrDefaultAsync(x => x.Username == username);
        }

        public async Task<bool> DaftarUserAsync(User data)
        {
            _context.Tb_User.Add(data);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Roles> AmbilRolesByIdAsync(string id)
        {
            return await _context.Tb_Roles.FindAsync(id);
        }

        public async Task<List<Roles>> AmbilSemuaRolesAsync()
        {
            return await _context.Tb_Roles.ToListAsync();
        }
    }
}
