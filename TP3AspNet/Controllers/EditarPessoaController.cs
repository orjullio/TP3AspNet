using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3AspNet.Models;

namespace TP3AspNet.Controllers
{
    public class EditarPessoaController : Controller
    {
        // GET: EditarPessoa
        public ActionResult Index()
        {
            var editar = new EditarPessoaModel
            {
                Editar = ""
            };

            return View(editar);
        }

        // GET: EditarPessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EditarPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EditarPessoa/Create
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

        // GET: EditarPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EditarPessoa/Edit/5
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

        // GET: EditarPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EditarPessoa/Delete/5
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
