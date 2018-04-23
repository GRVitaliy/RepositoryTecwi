using TamgaMVCAutofac.Core.Interfaces;
using TamgaMVCAutofac.Core.Model;
using System.Linq;
using System.Web.Mvc;

namespace TamgaMVCAutofac.Web.Controllers
{
    public class UserController : Controller
    {
        private IRepository repo;
        public UserController(IRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var teams = repo.GetAll<User>().ToList();
            return View(teams);
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
            if (ModelState.IsValid)
            {
                repo.Insert<User>(user);
                repo.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View();
        }
    }
}