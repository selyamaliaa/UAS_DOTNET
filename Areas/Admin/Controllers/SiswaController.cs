using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.data;
using UAS_DOTNET.Models;
using UAS_DOTNET.Services.SiswaService;

namespace UAS_DOTNET.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SiswaController : Controller
    {
        private readonly ISiswaService _sisServ;
        private readonly AppDbContext _context;
        public SiswaController(ISiswaService sisServ, AppDbContext context)
        {
            _sisServ = sisServ;
            _context = context;
        }
        public IActionResult TambahSiswa()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TambahSiswa(Siswa Parameter) 
        {
            string[] Id = _context.Tb_Siswa.Select(x => x.NIS).ToArray();
            if (ModelState.IsValid)
            {
                _context.Add(Parameter);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            return View(Parameter);
        }
        public IActionResult Index()
        {
            var banyak = _sisServ.AmbilSemuasiswa();
            return View(banyak);
        }
        public async Task<IActionResult> Hapus(string id)
        {
            var cari = _context.Tb_Siswa.Where(x => x.NIS == id).FirstOrDefault();
            if (cari == null)
            {
                return NotFound();
            }
            _context.Tb_Siswa.Remove(cari);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Ubah(string NIS) {
            //var cari = await _sisServ.TampilPaketById(NIS);
            //if (cari == null)
            //{
            //    return NotFound();
            //}
            //return View(cari);
            return View();
        }
    }
}
