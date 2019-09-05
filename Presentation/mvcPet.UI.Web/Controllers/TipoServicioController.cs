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
    public class TipoServicioController : Controller
    {
        // GET: TipoServicio
        public ActionResult Index()
        {
            ITipoServicioService tipoServicioService = new TipoServicioService();
            var lista = tipoServicioService.ListarTodos();

            return View(lista);
        }

        // GET: TipoServicio/ListaPrecios/5
        public ActionResult ListaPrecios(int id)
        {
            ITipoServicioService tipoServicioService = new TipoServicioService();
            var tipoServicio = tipoServicioService.BuscarPorId(id);

            IPrecioService precioService = new PrecioService();
            var precios = precioService.BuscarPorTipoServicio(id);

            tipoServicio.Precios = new List<Precio>(precios);

            return View(tipoServicio);
        }

        // GET: TipoServicio/NuevoPrecio
        public ActionResult NuevoPrecio(int id)
        {
            try
            {
                ITipoServicioService tipoServicioService = new TipoServicioService();
                var tipoServicio = tipoServicioService.BuscarPorId(id);

                IPrecioService precioService = new PrecioService();
                var precio = new Precio
                {
                    TipoServicioId = id,
                    TipoServicio = tipoServicio
                };

                return View(precio);
            }
            catch (Exception)
            {
                return View();
                throw;
            }
        }

        // POST: TipoServicio/NuevoPrecio
        [HttpPost]
        public ActionResult NuevoPrecio(Precio precio)
        {
            try
            {
                IPrecioService precioService = new PrecioService();
                precioService.Agregar(precio);
                return RedirectToAction("ListaPrecios", new { id = precio.TipoServicioId } );
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoServicio/EditarPrecio/5
        public ActionResult EditarPrecio(int id)
        {
            IPrecioService precioService = new PrecioService();
            Precio precio = precioService.BuscarPorId(id);

            if(precio == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(precio);
            }

        }

        // POST: TipoServicio/EditarPrecio/5
        [HttpPost]
        public ActionResult EditarPrecio(Precio precio)
        {
            try
            {
                IPrecioService precioService = new PrecioService();
                precioService.Editar(precio);
                return RedirectToAction("ListaPrecios", new { id = precio.TipoServicioId });
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoServicio/Details/5
        public ActionResult Details(int id)
        {
            ITipoServicioService tipoServicioService = new TipoServicioService();
            var tipoServicio = tipoServicioService.BuscarPorId(id);

            if(tipoServicio == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(tipoServicio);
            }

        }

        // GET: TipoServicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoServicio/Create
        [HttpPost]
        public ActionResult Create(TipoServicio model)
        {
            try
            {
                ITipoServicioService tipoServicioService = new TipoServicioService();
                tipoServicioService.Agregar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoServicio/Edit/5
        public ActionResult Edit(int id)
        {
            ITipoServicioService tipoServicioService = new TipoServicioService();
            TipoServicio tipoServicio = tipoServicioService.BuscarPorId(id);
            return View(tipoServicio);
        }

        // POST: TipoServicio/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoServicio tipoServicio)
        {
            try
            {
                ITipoServicioService tipoServicioService = new TipoServicioService();
                tipoServicioService.Editar(tipoServicio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoServicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoServicio/Delete/5
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
