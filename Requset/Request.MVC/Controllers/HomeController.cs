using Microsoft.AspNetCore.Mvc;
using Request.MVC.Model.RequsetPerson;
using Requset.Core.Contracts.NewFolder;
using Requset.Domain.Core.Requset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Request.MVC.Controllers
{
    public class HomeController:Controller
    {
        private readonly IRequestPersonRepository requestPersonRepository;

        public HomeController(IRequestPersonRepository requestPersonRepository)
        {
            this.requestPersonRepository = requestPersonRepository;
        }
        public IActionResult Index()
        {
            AddNewRequsetPersonViewModel model = new AddNewRequsetPersonViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(AddNewRequsetPersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                RequsetPerson requsetPerson = new RequsetPerson
                {
                    City = model.City,
                    Datetime = model.Datetime,
                    Details = model.Details,
                    Email = model.Email,
                    Family = model.Family,
                    Name = model.Name,
                    Phone = model.Phone,
                    RequsetType = model.RequsetType
                };
                requestPersonRepository.Add(requsetPerson);
            }
            return View();
        }
       

    }
}
