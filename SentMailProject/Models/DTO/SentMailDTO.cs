using SentMailProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.DTO
{
    public class SentMailDTO
    {
        public AppUser  appUser { get; set; }
        public SentMail  sentMail { get; set; }
        public AppUser sender { get; set; }
        public AppUser toWho { get; set; }
    }
}
