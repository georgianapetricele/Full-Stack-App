using Backend.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class ContactsDbContext: DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
