using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceThree.Controllers
{
    public class RandomLetter : Controller
    {
        public void Main(string[] args)
        {
            var randomLetters = Generator.RandomLetters(3);
            Console.WriteLine($"{randomLetters}");
        }
        [HttpGet]
        public ActionResult<string> Get()
        {
            var randomLetters = Generator.RandomLetters(3);

            return randomLetters.ToString();
        }
    }
}
