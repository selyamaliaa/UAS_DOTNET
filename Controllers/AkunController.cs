using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UAS_DOTNET.data;
using UAS_DOTNET.Models;
using UAS_DOTNET.Services.AkunService;

namespace UAS_DOTNET.Controllers
{
    public class AkunController : Controller
    {
        private readonly IAkunService _akSer;
        private readonly AppDbContext _context;

        public AkunController(IAkunService akSer, AppDbContext context)
        {
            _akSer = akSer;
            _context = context;
        }
        public IActionResult Daftar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Daftar(User data)
        {
            if (ModelState.IsValid)
            {
                _akSer.DaftarUser(data);

                return RedirectToAction("LogIn");
            }
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(User parameter)
        {
            var cariUser = _context.Tb_User
                .Where(x => x.Username == parameter.Username
                    && x.Password == parameter.Password)
                .Include(x => x.Roles)
                .FirstOrDefault();

            if (cariUser != null)
            {
                var claims = new List<Claim> {
                    new Claim("Username", cariUser.Username),
                    new Claim("Role", cariUser.Roles.Name)
                };

                await HttpContext.SignInAsync(new ClaimsPrincipal(
                    new ClaimsIdentity(claims, "Cookies", "Username", "Role")
                    ));

                if (cariUser.Roles.Id == "1")
                {
                    return Redirect("/Admin/Home");
                }
                else if (cariUser.Roles.Id == "2")
                {
                    return Redirect("/User/Home");
                }

                return Redirect("/LogIn");
            }

            if (!string.IsNullOrEmpty(parameter.Username) && !string.IsNullOrEmpty(parameter.Password))
            {
                ViewBag.Pesan = "Pengguna tidak ditemukan";
            }

            return View(parameter);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
