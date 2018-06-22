using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Controllers
{
    public class PlaceController : Controller
    {
        private PlaceServiceContract Service { get; set; }

        public PlaceController (PlaceServiceContract service)
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
            return View(new Place());
        }

        [HttpPost]
        public IActionResult Save(Place place)
        {
            this.Service.Create(place);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Place place = this.Service.FindById(id);
            return View(place);
        }

        [HttpPost]
        public IActionResult Patch(Place place)
        {
            this.Service.Update(place);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Place place = this.Service.FindById(id);
            return View(place);
        }

        [HttpPost]
        public IActionResult ConfirmDeletion(int id)
        {
            Place place = this.Service.FindById(id);
            this.Service.Delete(place);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<Place> placeList = this.Service.all();
            return View(placeList);
        }
    }
}