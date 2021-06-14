using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceFour.Controllers
{
    public class GeneratorService : Controller
    {
        static void Main(string[] args)
        {
            var randomPassword = Generator.RandomPassword();
            Console.WriteLine($"{randomPassword}");
            Console.ReadKey();
        }
    }
}
