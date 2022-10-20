using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.Context
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }


        public List<Sender> Senders { get; set; }
        public List<ToWho> ToWhos { get; set; }
    }
}
