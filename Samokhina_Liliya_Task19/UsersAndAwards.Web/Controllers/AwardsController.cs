using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAndAwards.Entities;
using UsersAndAwards.Logic;

namespace UsersAndAwards.Web.Controllers
{
    public class AwardsController : Controller
    {
        BLogic logic = new BLogic();

        // GET: Awards
        public ActionResult Index()
        {
            return View(logic.GetAllAwards());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Award newAward)
        {
            if (ModelState.IsValid)
            {
                logic.AddAward(newAward);
                return RedirectToAction("Index");
            }
            else
            {
                return View(newAward);
            }
        }

        public ActionResult Edit(int id)
        {
            var award = logic.GetAllAwards().FirstOrDefault(a => a.ID == id);
            return View(award);
        }

        [HttpPost]
        public ActionResult Edit(int id, Award award)
        {
            logic.EditAward(award);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var award = logic.GetAllAwards().FirstOrDefault(a => a.ID == id);
            return View(award);
        }

        public ActionResult Delete(int id)
        {
            var award = logic.GetAllAwards().FirstOrDefault(a => a.ID == id);
            return View(award);
        }

        [HttpPost]
        public ActionResult Delete(int id, Award award)
        {
            logic.RemoveAward(award);
            return RedirectToAction("Index");
        }
    }
}