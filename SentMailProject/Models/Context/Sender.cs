using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.Context
{
    public class Sender
    {
        public int ID { get; set; }

        public SentMail SentMail { get; set; }


        public AppUser AppUser { get; set; }
        public int AppUserID { get; set; }
    }
}
