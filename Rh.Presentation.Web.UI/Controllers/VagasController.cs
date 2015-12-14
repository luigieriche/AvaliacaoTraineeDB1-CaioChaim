using AutoMapper;
using Rh.Application.Interfaces;
using Rh.Domain.Entities;
using Rh.Presentation.Web.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rh.Presentation.Web.UI.Controllers
{
    public class VagasController : Controller
    {
        private readonly IVagaAppService _vagaApp;

        public VagasController(IVagaAppService vagaApp)
        {
            _vagaApp = vagaApp;
        }

        // GET: Vagas
        public ActionResult Index()
        {
            var vagaViewModel = Mapper.Map<IEnumerable<Vaga>, IEnumerable<VagaViewModel>>(_vagaApp.GetAll());
            return View(vagaViewModel);
        }

        // GET: Vagas/Details/5
        public ActionResult Details(int id)
        {
            var vaga = _vagaApp.GetById(id);
            var vagaViewModel = Mapper.Map<Vaga, VagaViewModel>(vaga);

            return View(vagaViewModel);
        }

        // GET: Candidatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Candidatos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VagaViewModel vaga)
        {
            if (ModelState.IsValid)
            {
                var vagaDomain = Mapper.Map<VagaViewModel, Vaga>(vaga);
                _vagaApp.Add(vagaDomain);

                return RedirectToAction("Index");
            }

            return View(vaga);
        }

        // GET: Candidatos/Edit/5
        public ActionResult Edit(int id)
        {
            var vaga = _vagaApp.GetById(id);
            var vagaViewModel = Mapper.Map<Vaga, VagaViewModel>(vaga);

            return View(vagaViewModel);
        }

        // POST: Candidatos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VagaViewModel vaga)
        {
            if (ModelState.IsValid)
            {
                var vagaDomain = Mapper.Map<VagaViewModel, Vaga>(vaga);
                _vagaApp.Add(vagaDomain);

                return RedirectToAction("Index");
            }

            return View(vaga);
        }

        // GET: Candidatos/Delete/5
        public ActionResult Delete(int id)
        {
            var vaga = _vagaApp.GetById(id);
            var vagaViewModel = Mapper.Map<Vaga, VagaViewModel>(vaga);

            return View(vagaViewModel);
        }

        // POST: Candidatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var vaga = _vagaApp.GetById(id);
            _vagaApp.Remove(vaga);

            return RedirectToAction("index");
        }

    }
}
