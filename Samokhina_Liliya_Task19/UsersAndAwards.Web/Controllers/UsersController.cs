using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersAndAwards.Entities;
using UsersAndAwards.Logic;
using UsersAndAwards.Web.Models;

namespace UsersAndAwards.Web.Controllers
{
    public class UsersController : Controller
    {
        BLogic logic = new BLogic();

        // GET: Users
        public ActionResult Index()
        {
            return View(logic.GetAllUsers().Select(u=> UserWebViewModel.GetViewModel(u, logic.GetAllAwards())));
        }

        public ActionResult Edit(int id)
        {
            var user = logic.GetAllUsers().FirstOrDefault(u => u.ID == id);
            return View(UserWebViewModel.GetViewModel(user, logic.GetAllAwards()));
        }

        [HttpPost]
        public ActionResult Edit(UserWebViewModel userModel)
        {
            var currentUser = logic.GetAllUsers().FirstOrDefault(u => u.ID == userModel.ID);
            if (currentUser != null)
            {
                var user = userModel.ToUser();
                currentUser.FirstName = user.FirstName;
                currentUser.LastName = user.LastName;
                currentUser.BirthDate = user.BirthDate;
                currentUser.UserAwards = user.UserAwards;
                logic.EditUser(user);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View(UserWebViewModel.GetViewModel(null, logic.GetAllAwards()));
        }

        [HttpPost]
        public ActionResult Create(UserWebViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                logic.AddUser(userModel.ToUser());
                return RedirectToAction("Index");
            }
            else
            {
                return View(UserWebViewModel.GetViewModel(userModel.ToUser(), logic.GetAllAwards()));
            }
        }

        public ActionResult Details(int id)
        {
            var user = logic.GetAllUsers().FirstOrDefault(u => u.ID == id);
            return View(UserWebViewModel.GetViewModel(user, logic.GetAllAwards()));
        }

        public ActionResult Delete(int id)
        {
            var user = logic.GetAllUsers().FirstOrDefault(u => u.ID == id);
            return View(UserWebViewModel.GetViewModel(user, logic.GetAllAwards()));
        }

        [HttpPost]
        public ActionResult Delete(int id, UserWebViewModel userModel)
        {
            var user = logic.GetAllUsers().FirstOrDefault(u => u.ID == id);
            if(user!= null)
            {
                logic.RemoveUser(user);
            }
            return RedirectToAction("Index");
        }
    }
}