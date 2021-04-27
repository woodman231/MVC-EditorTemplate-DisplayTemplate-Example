using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_EditorTemplate_DisplayTemplate_Example.Models
{
    public partial class PersonDbContext : DbContext
    {
        public PersonDbContext()
        {
        }

        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Person> People { get; set; }
    }
}
