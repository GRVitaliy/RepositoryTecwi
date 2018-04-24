using AppMVCAutofac.Core.Interfaces;
using AppMVCAutofac.Core.Model;
using System;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace AppMVCAutofac.Web.Controllers
{
    public class UserController : Controller
    {
        private IRepository repo;
        private IUserRepository userrepo;
        public UserController(IRepository repo, IUserRepository userrepo)
        {
            this.repo = repo;
            this.userrepo = userrepo;
        }

        [HttpGet]
         public ActionResult Index()
        {
            var teams = repo.GetAll<User>().ToList();
            return View(teams);
        }

        [HttpPost]
        public ActionResult Index(string strName)
        {
            var susers = userrepo.SearchUser(strName).ToList();
             return View(susers);
        }

        [HttpGet]
        public ActionResult InsertUser()
        {
            return View();
        }

        public ActionResult UserDetails(int id)
        {
            ViewBag.UserId = id;
            return View();
        }
        
        [HttpPost]
       public ActionResult InsertUser(User user)
        {

            string DataStart = Request["StartDate"];
             DateTime dateS = DateTime.ParseExact(DataStart, "dd.MM.yyyy", CultureInfo.CurrentCulture);
             user.StartDate = dateS;

                 repo.Insert<User>(user);
                repo.SaveChanges();
                return RedirectToAction("Index");
           
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = repo.GetById<User>(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            string DataStart = Request["StartDate"];
            DateTime dateS = DateTime.ParseExact(DataStart, "dd.MM.yyyy", CultureInfo.CurrentCulture);
            user.StartDate = dateS;

            if (ModelState.IsValid)
            {
                repo.Update<User>(user);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id = 0)
        {

            return View(repo.GetById<User>(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int id, string page)
        {
            ViewBag.lst = page;
            var drow = repo.GetById<User>(id);
            repo.Delete<User>(drow);
            repo.SaveChanges();
            return RedirectToAction("Index", new { page = page });
        }


    }
}