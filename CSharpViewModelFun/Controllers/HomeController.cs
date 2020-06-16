using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.Message = "This is a string";

            return View();
        }

        [HttpGet]
        [Route("/numbers")]
        public IActionResult Number()
        {
            Random rand = new Random();
            int[] arrNum = new int[10];
            for(int i = 0; i < 10; i++)
            {
                arrNum[i] = rand.Next();
                
            }
            ViewBag.Nums = arrNum;
            return View();
        }

        [HttpGet]
        [Route("/user")]
        public IActionResult Person()
        {
            Person dude = new Person
            {
                fname = "Joey",
                lname = "Weber"
            };
            ViewBag.User = dude;
            return View("Person", dude);
        }

        [HttpGet]
        [Route("/users")]
        public IActionResult People()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("In the people route");
            Console.WriteLine("***********************************************");
            Person Joey = new Person
            {
                fname = "Joey",
                lname = "Weber"
            };
            Person Nicole = new Person
            {
                fname = "Nicole",
                lname = "Weber"
            };
            Person Chris = new Person
            {
                fname = "Chris",
                lname = "Jager"
            };
            List<Person> people = new List<Person>()
            {
                Joey, Nicole, Chris
            };
            ViewBag.User = people;
            return View("People", people);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel{ RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}