using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.Repositories.AkunRepository
{
    public interface IAkunRepository
    {
        Task<bool> DaftarUserAsync(User data);
        Task<User> CariUserAsync(string username);

        Task<List<User>> AmbilSemuaUserAsync();
        Task<User> AmbilUserByUsernameAsync(string username);

        Task<List<Roles>> AmbilSemuaRolesAsync();
        Task<Roles> AmbilRolesByIdAsync(string id);
    }
}
