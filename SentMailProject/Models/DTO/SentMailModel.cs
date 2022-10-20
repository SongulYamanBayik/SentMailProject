using SentMailProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.DTO
{
    public class SentMailModel
    {
        public List<MailDTO> senderMails { get; set; }
        public List<MailDTO> toWhosMails { get; set; }
        public List<MailDTO> starMails { get; set; }
        public AppUser appUser { get; set; }
        public SentMail sentMails { get; set; }

    }
}
