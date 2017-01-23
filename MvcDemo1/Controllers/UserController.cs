using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo1.Models;

namespace MvcDemo1.Controllers
{
    public class UserController : Controller
    {
        private static IUserRepository _repository = new UserRepository();
        // GET: User
        public ActionResult Index()
        {
            return View(_repository.Users);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel userModel)
        {
            _repository.CreateUser(userModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete([Bind(Prefix = "id")]int userId)
        {
            return View(_repository.GetUserBy(userId));
        }

        [HttpPost]
        public ActionResult Delete(UserModel user)
        {
            _repository.DeleteUser(user.Id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit([Bind(Prefix = "id")]int userId)
        {
            return View(_repository.GetUserBy(userId));
        }

        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            _repository.UpdateUser(user);
            return RedirectToAction("Index");
        }

    }
}