using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

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
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient("Eric"); /* Set Recipient (@Model.GetRecipient) to "Eric" */
          myLetterVariable.SetSender("John");  /* Set Sender (@Model.GetSender) to "John" */
          return View(myLetterVariable); //Navigates to Views/Home/Letter.cshtml template
        }

        [Route("/myfantasticjourney")] //We can name the Route whatever we want
        public ActionResult Journal()  /*Template name MUST match filename that we're pulling */
        {
          return View(); //Navigates ti Views/Home/Journal.cshtml template
        }

        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }

        [Route("/greeting_card")]
        public ActionResult GreetingCard()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.SetRecipient(Request.Query["recipient"]);
            myLetterVariable.SetSender(Request.Query["sender"]);
            return View("Letter", myLetterVariable);
        }

    }
}
