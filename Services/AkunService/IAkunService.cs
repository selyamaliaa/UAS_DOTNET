using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.Services.AkunService
{
    public interface IAkunService
    {
        bool DaftarUser(User data);

        List<User> AmbilSemuaUser();
        User AmbilUserByUsername(string Username);

        List<Roles> AmbilSemuaRoles();
        Roles AmbilRolesById(string id);
    }
}
