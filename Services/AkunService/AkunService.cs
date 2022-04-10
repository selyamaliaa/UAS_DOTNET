using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;
using UAS_DOTNET.Repositories.AkunRepository;

namespace UAS_DOTNET.Services.AkunService
{
    public class AkunService : IAkunService
    {
        private readonly IAkunRepository _akRepo;

        public AkunService(IAkunRepository akRepo)
        {
            _akRepo = akRepo;
        }

        public bool DaftarUser(User data)
        {
            data.Roles = _akRepo.AmbilRolesByIdAsync("2").Result;

            return _akRepo.DaftarUserAsync(data).Result;
        }

        public Roles AmbilRolesById(string id)
        {
            return _akRepo.AmbilRolesByIdAsync(id).Result;
        }

        public List<Roles> AmbilSemuaRoles()
        {
            return _akRepo.AmbilSemuaRolesAsync().Result;
        }

        public List<User> AmbilSemuaUser()
        {
           return _akRepo.AmbilSemuaUserAsync().Result;
        }

        public User AmbilUserByUsername(string Username)
        {
            return _akRepo.AmbilUserByUsernameAsync(Username).Result;
        }
    }
}
