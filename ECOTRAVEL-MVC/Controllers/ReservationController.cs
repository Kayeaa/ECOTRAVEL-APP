using BLL.Entities;
using Common.Repositories;
using ECOTRAVEL_MVC.Models.ReservationModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECOTRAVEL_MVC.Handlers;

namespace ECOTRAVEL_MVC.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationRepository<Reservation, int> _services;

        public ReservationController(IReservationRepository<Reservation, int> services)
        {
            _services = services;
        }

        // GET: ReservationController
        public ActionResult Index()
        {
            IEnumerable<ReservationListItem> model = _services.Get().Select(e => e.ToListItem());
            return View(model);
        }

        // GET: ReservationController/Details/5
        public ActionResult Details(int id)
        {
            ReservationDetails model = _services.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Réservation non trouvé...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservationCreateForm form)
        {
            if (!ModelState.IsValid)
            {

                return View(form);
            }
            else
            {
                int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Details", "Reservation", new { id = id });
            }
        }

        // POST: ReservationController/Create
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

        // GET: ReservationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservationController/Edit/5
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

        // GET: ReservationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservationController/Delete/5
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
