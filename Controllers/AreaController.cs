using System;
using Microsoft.AspNetCore.Mvc;
using Genealogia.Models;

namespace Genealogia.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}