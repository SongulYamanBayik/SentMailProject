using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.Context
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=Db.SentMail; integrated security=True");
        }

        public DbSet<SentMail> SentMails { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<ToWho> ToWhos { get; set; }
    }
}
