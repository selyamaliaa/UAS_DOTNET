using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.Repositories.SiswaRepository
{
    public interface ISiswaRepository
    {
        Task<List<Siswa>> AmbilSemuaSiswaAsync();
    }
}
