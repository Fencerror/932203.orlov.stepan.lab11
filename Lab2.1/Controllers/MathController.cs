using Microsoft.AspNetCore.Mvc;
using MathServiceApp.Models;
using System;

namespace MathServiceApp.Controllers
{
    public class MathController : Controller
    {
        public IActionResult UsingModel()
        {
            var model = new RandomNumbersViewModel
            {
                Num1 = new Random().Next(1, 11),
                Num2 = new Random().Next(1, 11)
            };

            return View(model);
        }

        public IActionResult UsingViewData()
        {
            Random random = new Random();
            ViewData["Num1"] = random.Next(1, 11);
            ViewData["Num2"] = random.Next(1, 11);
            return View();
        }

        public IActionResult UsingViewBag()
        {
            Random random = new Random();
            ViewBag.Num1 = random.Next(1, 11);
            ViewBag.Num2 = random.Next(1, 11);
            return View();
        }

        public IActionResult UsingService()
        {
            var model = new RandomNumbersViewModel
            {
                Num1 = new Random().Next(1, 11),
                Num2 = new Random().Next(1, 11)
            };

            return View(model);
        }
    }
}
