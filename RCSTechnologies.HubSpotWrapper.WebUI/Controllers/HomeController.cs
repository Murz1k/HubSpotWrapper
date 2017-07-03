using System;
using Microsoft.AspNetCore.Mvc;
using RCSTechnologies.HubSpotWrapper.DAL;
using RCSTechnologies.HubSpotWrapper.WebUI.Models;

namespace RCSTechnologies.HubSpotWrapper.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var service = _unitOfWork.Get<IHSContactService>();

            IndexModel model = new IndexModel
            {
                Contacts = service.GetAll()
            };

            //var contact = new HSContact()
            //{
            //    Address = "Moscow",
            //    City = "Msc",
            //    Company = "DreamTeam",
            //    CreateDate = DateTime.Now,
            //    Email = "adsd@gmail.com",
            //    FirstName = "Maks",
            //    LastName = "Zakharov",
            //    Phone = "+79254306274",
            //    State = "MSC",
            //    Zip = "123214",
            //    Website = "www.google.com"
            //};
            //service.Add(contact);
            //return View(service.SearchContactsByEmailOrNameOrCompanyName("Updated"));
            //var s = _unitOfWork.Get<ITLEventTypeService>();
            //s.Add(new TLEventType { Name = "F1" });
            //var types = s.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult SearchContact(string search)
        {
            var service = _unitOfWork.Get<IHSContactService>();
            return Json(service.SearchContactsByEmailOrNameOrCompanyName(search));
        }

        [HttpPost]
        public void AddContact(HSContact contact)
        {
            var service = _unitOfWork.Get<IHSContactService>();
            service.Add(contact);
        }

        [HttpDelete]
        public void DeleteContact(long id)
        {
            var service = _unitOfWork.Get<IHSContactService>();
            service.Delete(id);
        }
    }
}
