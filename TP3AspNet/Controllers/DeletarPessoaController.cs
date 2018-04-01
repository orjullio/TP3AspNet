using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3AspNet.Models;

namespace TP3AspNet.Controllers
{
    public class DeletarPessoaController : Controller
    {
        // GET: DeletarPessoa
        public ActionResult Index()
        {
            var deletar = new DeletarPessoaModel
            {
                Deletar = ""
            };
            return View(deletar);
        }

        // GET: DeletarPessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeletarPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeletarPessoa/Create
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

        // GET: DeletarPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeletarPessoa/Edit/5
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

        // GET: DeletarPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeletarPessoa/Delete/5
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
