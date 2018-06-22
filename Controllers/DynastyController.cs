using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Controllers
{
    public class DynastyController : Controller
    {
        private DynastyServiceContract Service { get; set; }

        public DynastyController (DynastyServiceContract service)
        {
            this.Service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Dynasty());
        }

        [HttpPost]
        public IActionResult Save(Dynasty dynasty)
        {
            this.Service.Create(dynasty);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Dynasty dynasty = this.Service.FindById(id);
            return View(dynasty);
        }

        [HttpPost]
        public IActionResult Patch(Dynasty dynasty)
        {
            this.Service.Update(dynasty);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Dynasty dynasty = this.Service.FindById(id);
            return View(dynasty);
        }

        [HttpPost]
        public IActionResult ConfirmDeletion(int id)
        {
            Dynasty dynasty = this.Service.FindById(id);
            this.Service.Delete(dynasty);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<Dynasty> dynastyList = this.Service.all();
            return View(dynastyList);
        }
    }
}