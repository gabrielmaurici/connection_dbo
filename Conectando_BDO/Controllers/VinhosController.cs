using Conectando_BDO.Models;
using Conectando_BDO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conectando_BDO.Controllers
{
    public class VinhosController : Controller
    {
        RepositoryVinhos repository = new RepositoryVinhos();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Vinhos model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        public ActionResult List()
        {
            return View(repository.Read());
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repository.Read(id));
        }
        [HttpPost]
        public ActionResult Edit(Vinhos model)
        {
            repository.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List");
        }
        public ActionResult Details(int id)
        {
            return View(repository.Read(id));
        }
    }
}