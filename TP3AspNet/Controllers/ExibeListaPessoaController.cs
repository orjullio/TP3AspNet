using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3AspNet.Models;

namespace TP3AspNet.Controllers
{
    public class ExibeListaPessoaController : Controller
    {
        // GET: ExibeListaPessoa
        public ActionResult Index()
        {
            var exibirLista = new ExibeListaPessoaModel
            {
                ExibeLista = ""
            };
            return View(exibirLista);
        }

        // GET: ExibeListaPessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExibeListaPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExibeListaPessoa/Create
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

        // GET: ExibeListaPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExibeListaPessoa/Edit/5
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

        // GET: ExibeListaPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExibeListaPessoa/Delete/5
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
