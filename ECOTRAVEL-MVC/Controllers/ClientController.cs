using BLL.Entities;
using Common.Repositories;
using ECOTRAVEL_MVC.Handlers;
using ECOTRAVEL_MVC.Models.ClientModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository<Client, int> _services;

        public ClientController(IClientRepository<Client, int> services)
        {
            _services = services;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            ClientDetails model = _services.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Client non trouvé...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
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

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
