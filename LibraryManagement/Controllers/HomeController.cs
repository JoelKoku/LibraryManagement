using Database_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private OnlineLabEntitiesDbEntities db = new OnlineLabEntitiesDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(string username, string password)
        {
            try {
                if(username != null && password != null)
                {
                    var findUser = db.UserTables.Where(u => u.UserName == username && u.Password == password && u.IsActive == true).ToList();
                    if (findUser.Count() == 1)
                    {
                        Session["UserID"] = findUser[0].UserID;
                        Session["UserTypeID"] = findUser[0].UserTypeID;
                        Session["UserName"] = findUser[0].UserName;
                        Session["Password"] = findUser[0].Password;
                        Session["EmployeeID"] = findUser[0].EmployeeID;

                        string url = string.Empty;
                        if (findUser[0].UserTypeID == 2)
                        {
                            return RedirectToAction("About");

                        }
                        else if (findUser[0].UserTypeID == 3)
                        {
                            return RedirectToAction("About");

                        }
                        else if (findUser[0].UserTypeID == 4)
                        {
                            return RedirectToAction("About");
                        }
                        else if (findUser[0].UserTypeID == 1)
                        {
                            url = "About";
                        }
                        else
                        {
                            url = "About";
                        }

                        return RedirectToAction(url);
                    }
                    else
                    {
                        Session["UserID"] = string.Empty;
                        Session["UserTypeID"] = string.Empty;
                        Session["UserName"] = string.Empty;
                        Session["Password"] = string.Empty;
                        Session["EmployeeID"] = string.Empty;
                        ViewBag.message = "User Name and Password is incorrect!";
                    }
                }
                else
                {
                    Session["UserID"] = string.Empty;
                    Session["UserTypeID"] = string.Empty;
                    Session["UserName"] = string.Empty;
                    Session["Password"] = string.Empty;
                    Session["EmployeeID"] = string.Empty;
                    ViewBag.message = "Some unexpected issus is occure please try again!";
                }
            } catch (Exception ex)
            {
                Session["UserID"] = string.Empty;
                Session["UserTypeID"] = string.Empty;
                Session["UserName"] = string.Empty;
                Session["Password"] = string.Empty;
                Session["EmployeeID"] = string.Empty;
                ViewBag.message = "Some unexpected issue is occure please try again !";
            }
            return View("Login");
        }
        public ActionResult Logout()
        {
            Session["UserID"] = string.Empty;
            Session["UserTypeID"] = string.Empty;
            Session["Password"] = string.Empty;
            Session["EmployeeID"] = string.Empty;
            return RedirectToAction("Login");
        }
    }
}