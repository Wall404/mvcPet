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
    public class PrecioController : Controller
    {
        // GET: Precio
        public ActionResult Index()
        {
            IPrecioService precioService = new PrecioService();
            var lista = precioService.ListarTodos();

            return View(lista);
        }

        // GET: Precio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Precio/Create
        public ActionResult Create()
        {
            var precio = new Precio();
            ITipoServicioService tipoServicioService = new TipoServicioService();
            foreach (var item in tipoServicioService.ListarTodos())
            {
                precio.TipoServicios.Add(item) ;
            }
            return View(precio);
        }

        // POST: Precio/Create
        [HttpPost]
        public ActionResult Create(Precio model)
        {
            try
            {
                IPrecioService precioService = new PrecioService();
                precioService.Agregar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Precio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Precio/Edit/5
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

        // GET: Precio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Precio/Delete/5
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
