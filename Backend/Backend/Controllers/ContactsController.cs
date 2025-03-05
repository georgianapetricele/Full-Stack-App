using Backend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Models.Domain;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsDbContext dbContext;
        public ContactsController(ContactsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = dbContext.Contacts.ToList();
            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddContact(AddContactDto requestContact)
        {
           var domainContact = new Contact
           {
               Id=Guid.NewGuid(),
               Name = requestContact.Name,
               Email = requestContact.Email,
               PhoneNumber = requestContact.PhoneNumber,
               Favourite = requestContact.Favourite
           };
            dbContext.Contacts.Add(domainContact);
            dbContext.SaveChanges();
            return Ok(domainContact);
        }
    } 
}
