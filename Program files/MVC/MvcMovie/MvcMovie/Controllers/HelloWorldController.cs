using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        //public string Index()
        //{
         //   return "This is my <b>default</b> action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.numTimes = numTimes;

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}