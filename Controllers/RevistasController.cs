using Arthes2022.Data;
using Arthes2022.Models.Entities;
using Arthes2022.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace Arthes2022.Controllers
{
    public class RevistasController : Controller
    {
        private readonly ArthesContext _context;
        public RevistasController(ArthesContext context) => _context = context;

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RevistaViewModel rvm)
        {
            Revista r = new Revista();
            r.Tema = rvm.Tema;
            r.NumeroEdicao = rvm.NumeroEdicao;
            r.AnoEdicao = rvm.AnoEdicao;
            r.MesEdicao = rvm.MesEdicao;
            r.Foto = rvm.Foto;

            _context.Add(r);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }

        [HttpGet]
        public IActionResult ListaRevistas() => View();
    }
}
