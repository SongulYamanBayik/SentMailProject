using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.Context
{
    public class SentMail
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool ReadStatus { get; set; }
        public bool SenderStarred { get; set; }
        public bool ToWhoStarred { get; set; }
        public bool SenderStatus { get; set; }
        public bool ToWhoStatus { get; set; }


        public Sender Sender { get; set; }
        public int SenderID { get; set; }

        public ToWho ToWho { get; set; }
        public int ToWhoID { get; set; }
    }
}
