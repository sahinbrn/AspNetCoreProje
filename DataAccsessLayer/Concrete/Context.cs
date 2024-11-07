using EntityLater;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete 
{
    public class Context : IdentityDbContext<Users, UsersRole, int>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TU9HOIK\\SQLEXPRESS;database=CoreProjeDB;integrated security=true");
        }

        public DbSet<Abouts> Abouts { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolios> Portfolios { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SocialMedya> SocialMedyas { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
    }
}
