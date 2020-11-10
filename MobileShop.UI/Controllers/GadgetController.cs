using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileShop.UI.Controllers
{
    public class GadgetController : Controller
    {
        // GET: Gadget
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gadget/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gadget/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gadget/Create
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

        // GET: Gadget/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gadget/Edit/5
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

        // GET: Gadget/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gadget/Delete/5
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

        public ActionResult GadgetList()
        {
            return View();
        }

        public ActionResult GadgetItemDetail()
        {
            return View();
        }
    }
}
