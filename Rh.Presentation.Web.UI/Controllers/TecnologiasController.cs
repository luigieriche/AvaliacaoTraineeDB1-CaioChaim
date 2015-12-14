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
    public class TecnologiasController : Controller
    {
        private readonly ITecnologiaAppService _tecnologiaApp;

        public TecnologiasController(ITecnologiaAppService tecnologiaApp)
        {
            _tecnologiaApp = tecnologiaApp;
        }

        // GET: Tecnologias
        public ActionResult Index()
        {
            var tecnologiaViewModel = Mapper.Map<IEnumerable<Tecnologia>, IEnumerable<TecnologiaViewModel>>(_tecnologiaApp.GetAll());
            return View(tecnologiaViewModel);
        }

        public ActionResult GetTecnologies()
        {
            var tecnologies = _tecnologiaApp.GetAll();
            return View(tecnologies);
        }

        // GET: Tecnologias/Details/5
        public ActionResult Details(int id)
        {
            var tecnologia = _tecnologiaApp.GetById(id);
            var tecnologiaViewModel = Mapper.Map<Tecnologia, TecnologiaViewModel>(tecnologia);

            return View(tecnologiaViewModel);
        }

        // GET: Tecnologias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tecnologias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TecnologiaViewModel tecnologia)
        {
            if (ModelState.IsValid)
            {
                var tecnologiaDomain = Mapper.Map<TecnologiaViewModel, Tecnologia>(tecnologia);
                _tecnologiaApp.Add(tecnologiaDomain);

                return RedirectToAction("Index");
            }

            return View(tecnologia);
        }

        // GET: Tecnologias/Edit/5
        public ActionResult Edit(int id)
        {
            var tecnologia = _tecnologiaApp.GetById(id);
            var tecnologiaViewModel = Mapper.Map<Tecnologia, TecnologiaViewModel>(tecnologia);

            return View(tecnologiaViewModel);
        }

        // POST: Tecnologias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TecnologiaViewModel tecnologia)
        {
            if (ModelState.IsValid)
            {
                var tecnologiaDomain = Mapper.Map<TecnologiaViewModel, Tecnologia>(tecnologia);
                _tecnologiaApp.Add(tecnologiaDomain);

                return RedirectToAction("Index");
            }

            return View(tecnologia);
        }

        // GET: Tecnologias/Delete/5
        public ActionResult Delete(int id)
        {
            var tecnologia = _tecnologiaApp.GetById(id);
            var tecnologiaViewModel = Mapper.Map<Tecnologia, TecnologiaViewModel>(tecnologia);

            return View(tecnologiaViewModel);
        }

        // POST: Tecnologias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var tecnologia = _tecnologiaApp.GetById(id);
            _tecnologiaApp.Remove(tecnologia);

            return RedirectToAction("index");
        }
    }
}
