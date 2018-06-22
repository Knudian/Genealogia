using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Genealogia.Data;
using Genealogia.Contracts.Services;


namespace Genealogia.Controllers
{
    public class AreaController : Controller
    {
        private AreaServiceContract Service { get; set; }

        public AreaController (AreaServiceContract service)
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
            return View(new Area());
        }

        [HttpPost]
        public IActionResult Save(Area area)
        {
            this.Service.Create(area);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Area area = this.Service.FindById(id);
            return View(area);
        }

        [HttpPost]
        public IActionResult Patch(Area area)
        {
            this.Service.Update(area);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Area area = this.Service.FindById(id);
            return View(area);
        }

        [HttpPost]
        public IActionResult ConfirmDeletion(int id)
        {
            Area area = this.Service.FindById(id);
            this.Service.Delete(area);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<Area> areaList = this.Service.all();
            return View(areaList);
        }
    }
}