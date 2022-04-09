using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Controllers
{
    public class AkunController : Controller
    {
        public IActionResult Daftar()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        
    }
}
