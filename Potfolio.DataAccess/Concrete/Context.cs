using Microsoft.EntityFrameworkCore;
using Portfolio.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Potfolio.DataAccess.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =DESKTOP-MT6QAH6\\SQLEXPRESS; database=DbCorePortfolio;Integrated Security=true");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }



    }
}
