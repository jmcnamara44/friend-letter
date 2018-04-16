using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")] //localhost:5000/hello in browser
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")] //localhost:5000/goodbye in browser
        public string Goodbye() { return "Goodbye friend."; }

    }
}
