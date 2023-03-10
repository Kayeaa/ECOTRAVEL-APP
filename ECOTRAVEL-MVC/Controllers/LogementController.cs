using BLL.Entities;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECOTRAVEL_MVC.Handlers;
using ECOTRAVEL_MVC.Models.LogementModelView;

namespace ECOTRAVEL_MVC.Controllers
{
    public class LogementController : Controller
    {
        private readonly ILogementRepository<Logement, int> _services;

        public LogementController(ILogementRepository<Logement, int> services)
        {
            _services = services;
        }

        // GET: LogementController
        public ActionResult Index()
        {
            IEnumerable<LogementListItem> model = _services.Get().Select(e => e.ToListItem());
            return View(model);
        }

        // GET: LogementController/Details/5
        public ActionResult Details(int id)
        {
            LogementDetails model = _services.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Logement non trouvé...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogementCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                form.LogNom = null;
                form.LogPays = null;
                return View(form);
            }
            else
            {
                int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Details", "Logement", new { id = id });
            }
        }

        // POST: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
