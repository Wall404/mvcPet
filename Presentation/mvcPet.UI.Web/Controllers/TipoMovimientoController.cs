using mvcPet.Services;
using mvcPet.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcPet.UI.Web.Controllers
{
    public class TipoMovimientoController : Controller
    {
        // GET: TipoMovimiento
        public ActionResult Index()
        {
            ITipoMovimientoService tipoMovimientoService = new TipoMovimientoService();
            var lista = tipoMovimientoService.ListarTodos();

            return View(lista);
        }

        // GET: TipoMovimiento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoMovimiento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMovimiento/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoMovimiento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoMovimiento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoMovimiento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoMovimiento/Delete/5
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
