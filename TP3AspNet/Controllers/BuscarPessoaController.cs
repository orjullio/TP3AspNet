using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3AspNet.Models;

namespace TP3AspNet.Controllers
{
    public class BuscarPessoaController : Controller
    {
        // GET: BuscarPessoa
        public ActionResult Index()
        {
            var buscarPessoa = new BuscarPessoaModel
            {
                Buscar = "Nome"                  
            };
            return View(buscarPessoa);
        }

        // GET: BuscarPessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuscarPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuscarPessoa/Create
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

        // GET: BuscarPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuscarPessoa/Edit/5
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

        // GET: BuscarPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuscarPessoa/Delete/5
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
