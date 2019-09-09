using mvcPet.Entities;
using mvcPet.Services;
using mvcPet.Services.Contracts;
using System.Web.Mvc;

namespace mvcPet.UI.Web.Controllers
{
    public class SalaController : Controller
    {
        // GET: Sala
        public ActionResult Index()
        {
            ISalaService salaService = new SalaService();
            var lista = salaService.ListarTodos();
            return View(lista);
        }

        // GET: Sala/Details/5
        public ActionResult Details(int id)
        {
            ISalaService salaService = new SalaService();
            Sala sala = salaService.BuscarPorId(id);
            if (sala == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(sala);
            }
        }

        // GET: Sala/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sala/Create
        [HttpPost]
        public ActionResult Create(Sala model)
        {
            try
            {
                ISalaService salaService = new SalaService();
                salaService.Agregar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sala/Edit/5
        public ActionResult Edit(int id)
        {
            ISalaService salaService = new SalaService();
            Sala e = salaService.BuscarPorId(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(e);
            }
        }

        // POST: Sala/Edit/5
        [HttpPost]
        public ActionResult Edit(Sala model)
        {
            try
            {
                ISalaService salaService = new SalaService();
                salaService.Editar(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sala/Delete/5
        public ActionResult Delete(int id)
        {
            ISalaService salaService = new SalaService();
            Sala e = salaService.BuscarPorId(id);
            if (e == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(e);
            }
        }

        // POST: Sala/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                ISalaService salaService = new SalaService();
                salaService.Eliminar(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
