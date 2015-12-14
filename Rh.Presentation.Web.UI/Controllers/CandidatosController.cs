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
    public class CandidatosController : Controller
    {
        private readonly ICandidatoAppService _candidatoApp;

        public CandidatosController(ICandidatoAppService candidatoApp)
        {
            _candidatoApp = candidatoApp;
        }

        // GET: Candidatos
        public ActionResult Index()
        {
            var candidatoViewModel = Mapper.Map<IEnumerable<Candidato>, IEnumerable<CandidatoViewModel>>(_candidatoApp.GetAll());
            return View(candidatoViewModel);
        }

        // GET: Candidatos/Details/5
        public ActionResult Details(int id)
        {
            var candidato = _candidatoApp.GetById(id);
            var candidatoViewModel = Mapper.Map<Candidato, CandidatoViewModel>(candidato);

            return View(candidatoViewModel);
        }

        // GET: Candidatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Candidatos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CandidatoViewModel candidato)
        {
            if (ModelState.IsValid)
            {
                var candidatoDomain = Mapper.Map<CandidatoViewModel, Candidato>(candidato);
                _candidatoApp.Add(candidatoDomain);

                return RedirectToAction("Index");
            }

            return View(candidato);
        }

        // GET: Candidatos/Edit/5
        public ActionResult Edit(int id)
        {
            var candidato = _candidatoApp.GetById(id);
            var candidatoViewModel = Mapper.Map<Candidato, CandidatoViewModel>(candidato);

            return View(candidatoViewModel);
        }

        // POST: Candidatos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CandidatoViewModel candidato)
        {
            if (ModelState.IsValid)
            {
                var candidatoDomain = Mapper.Map<CandidatoViewModel, Candidato>(candidato);
                _candidatoApp.Add(candidatoDomain);

                return RedirectToAction("Index");
            }

            return View(candidato);
        }

        // GET: Candidatos/Delete/5
        public ActionResult Delete(int id)
        {
            var candidato = _candidatoApp.GetById(id);
            var candidatoViewModel = Mapper.Map<Candidato, CandidatoViewModel>(candidato);

            return View(candidatoViewModel);
        }

        // POST: Candidatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var candidato = _candidatoApp.GetById(id);
            _candidatoApp.Remove(candidato);

            return RedirectToAction("index");
        }

    }
}
