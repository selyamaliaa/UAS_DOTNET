using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;
using UAS_DOTNET.Repositories.SiswaRepository;
using UAS_DOTNET.Services.SiswaService;

namespace UAS_DOTNET.Services.NewFolder
{
    public class SiswaService : ISiswaService
    {
        private readonly ISiswaRepository _sisRepo;

        public SiswaService(ISiswaRepository sisRepo)
        {
            _sisRepo = sisRepo;
        }

        public List<Siswa> AmbilSemuasiswa()
        {
            return _sisRepo.AmbilSemuaSiswaAsync().Result;
        }
    }
}
