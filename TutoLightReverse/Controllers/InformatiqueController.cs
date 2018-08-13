using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using TutoLightReverse.Models;
using BLL;

namespace TutoLightReverse.Controllers
{
    public class InformatiqueController : Controller
    {
        // GET: Informatique
        public ActionResult Index()
        {
            return View(InformatiqueManager.GetList());
        }

        // GET: Informatique/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Informatique/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Informatique/Create
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

        // GET: Informatique/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Informatique/Edit/5
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

        // GET: Informatique/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Informatique/Delete/5
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
