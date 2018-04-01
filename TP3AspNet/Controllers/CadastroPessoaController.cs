using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP3AspNet.Models;

namespace TP3AspNet.Controllers
{
    public class CadastroPessoaController : Controller
    {
        // GET: CadastroPessoa
        public ActionResult Index()
        {
            var cadastro = new CadastroPessoaModel
            {
                Nome = "",
                Sobrenome = "",
                Aniversario = ""

            };

            return View(cadastro);
        }

        // GET: CadastroPessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroPessoa/Create
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

        // GET: CadastroPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadastroPessoa/Edit/5
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

        // GET: CadastroPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastroPessoa/Delete/5
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
