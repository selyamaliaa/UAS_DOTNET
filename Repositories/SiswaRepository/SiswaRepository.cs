using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.data;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.Repositories.SiswaRepository
{
    public class SiswaRepository : ISiswaRepository
    {
        private readonly AppDbContext _context;

        public SiswaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Siswa>> AmbilSemuaSiswaAsync()
        {
            return await _context.Tb_Siswa.ToListAsync();
        }
    }
}
