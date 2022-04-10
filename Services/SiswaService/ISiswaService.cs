using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.Services.SiswaService
{
    public interface ISiswaService
    {
        List<Siswa> AmbilSemuasiswa();
    }
}
