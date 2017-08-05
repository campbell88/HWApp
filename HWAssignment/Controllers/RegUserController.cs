using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HWAssignment.Models;
namespace HWAssignment.Controllers
{
    public class RegUserController : Controller
    {
        // GET: RegUser
        public ActionResult AdminReport()
        {
            using (UserDbContext db = new UserDbContext())
            {
                return View(db.userAccount.ToList());


            }
        }
        public ActionResult Register()
        {
            return View();


        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                using (UserDbContext db = new UserDbContext())
                {
                    db.userAccount.Add(user);
                    db.SaveChanges();

                }
                ModelState.Clear();
                ViewBag.Message = user.FirstName + ", you are successfully registered.";

            }
            return View();
        }

            public ActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Login(User user)
        {

            using (UserDbContext db = new UserDbContext())
            {
                var userInfo = db.userAccount.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
                if (userInfo != null)

                {
                    Session["UserID"] = userInfo.UserID.ToString();
                    Session["Email"] = userInfo.Email.ToString();
                    return RedirectToAction("LoggedIn");

                }
                else
                {
                    ModelState.AddModelError("", "E-mail and/or Password is incorrect");
                }
            }
            return View();

        }

        public ActionResult LoggedIn()
        {
            if (Session[ "Email"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }


        }

        }

    }


