using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Controllers
{
    public class PersonController : Controller
    {
        private PersonServiceContract Service { get; set; }

        public PersonController (PersonServiceContract service)
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
            return View(new Person());
        }

        [HttpPost]
        public void Save(Person person)
        {
            Console.WriteLine(person.ToString());

            //this.Service.Create(person);
            //return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Person person = this.Service.FindById(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Patch(Person person)
        {
            this.Service.Update(person);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Person person = this.Service.FindById(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult ConfirmDeletion(int id)
        {
            Person person = this.Service.FindById(id);
            this.Service.Delete(person);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<Person> personList = this.Service.all();
            return View(personList);
        }
    }
}