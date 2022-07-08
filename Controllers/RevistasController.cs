using Arthes2022.Data.Interface;
using Arthes2022.Models.Entities;
using Arthes2022.Models.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace Arthes2022.Controllers
{
    public class RevistasController : Controller
    {
        private readonly IRevistaManager _revistaManager;
        public RevistasController(IRevistaManager revistaManager) => _revistaManager = revistaManager;


        [HttpGet]
        public async Task<IActionResult> ListaRevista()
        {
            IEnumerable<Revista>? listaRevista = await _revistaManager.GetRevistasAsync();
            return View(listaRevista);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> DetalheRevista(int Id)
        {
            Revista? revista = await _revistaManager.GetRevistaAsyncById(Id);
            return View(revista);
        }


        [HttpPost]
        public async Task<IActionResult> InsertRevista(RevistaViewModel rvm)
        {
            Revista r = new Revista();
            r.Tema = rvm.Tema;
            r.NumeroEdicao = rvm.NumeroEdicao;
            r.AnoEdicao = rvm.AnoEdicao;
            r.MesEdicao = rvm.MesEdicao;
            r.Foto = rvm.Foto;

            //Revista revistaIncluida = 
            await _revistaManager.InsertRevistaAsync(r);
            return RedirectToAction("ListaRevista");
        }
    }
}
