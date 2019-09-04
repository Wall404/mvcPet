﻿using mvcPet.Entities;
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
        public ActionResult NuevoPrecio(Precio model)
        {
            try
            {
                IPrecioService precioService = new PrecioService();
                precioService.Agregar(model);
                return RedirectToAction("ListaPrecios", new { id = model.TipoServicioId } );
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoServicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            ITipoServicioService tipoServicio = new TipoServicioService();
            TipoServicio t = tipoServicio.BuscarPorId(id);
            return View(t);
        }

        // POST: TipoServicio/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoServicio model)
        {
            try
            {
                ITipoServicioService tipoServicioService = new TipoServicioService();
                tipoServicioService.Editar(model);
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
