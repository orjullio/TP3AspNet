using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3AspNet.Models;

namespace TP3AspNet.Controllers
{
    public class DetalhePessoaController : Controller
    {
        // GET: DetalhePessoa
        public ActionResult Index()
        {
            var detalhes = new DetalhePessoaModel
            {
                Detalhes = ""
            };

            return View(detalhes);
        }

        // GET: DetalhePessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DetalhePessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetalhePessoa/Create
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

        // GET: DetalhePessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DetalhePessoa/Edit/5
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

        // GET: DetalhePessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DetalhePessoa/Delete/5
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
