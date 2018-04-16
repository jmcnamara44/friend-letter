using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")] //localhost:5000/hello in browser
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")] //localhost:5000/goodbye in browser
        public string Goodbye() { return "Goodbye friend."; }


        [Route("/")]
        public ActionResult Letter() /* Looks for the "Letter" template by filename */
        { /* ActionResult automatically converts text/html without decorator */
          return View(); //Navigates to Views/Home/Letter.cshtml template
        }

        [Route("/myfantasticjourney")] //We can name the Route whatever we want
        public ActionResult Journal()  /*Template name MUST match filename that we're pulling */
        {
          return View(); //Navigates ti Views/Home/Journal.cshtml template
        }

    }
}
