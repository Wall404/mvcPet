using mvcPet.Entities;
using mvcPet.Services;
using mvcPet.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcPet.UI.Web.Controllers
{
    public class EspeciesController : Controller
    {
        // GET: Especies
        public ActionResult Index()
        {
            IEspecieService especieService = new EspecieService();
            var lista = especieService.ListarTodos();
            
            return View(lista);
        }

        // GET: Especies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Especies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Especies/Create
        [HttpPost]
        public ActionResult Create(Especie model)
        {
            try
            {
                // TODO: Add insert logic here
                IEspecieService especieService = new EspecieService();
                especieService.Agregar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especies/Edit/5
        public ActionResult Edit(int id)
        {
            IEspecieService especieService = new EspecieService();
            Especie e = especieService.BuscarPorId(id);
            return View(e);
        }

        // POST: Especies/Edit/5
        [HttpPost]
        public ActionResult Edit( Especie model)
        {
            try
            {
                // TODO: Add update logic here
                IEspecieService especieService = new EspecieService();
                especieService.Editar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Especies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
