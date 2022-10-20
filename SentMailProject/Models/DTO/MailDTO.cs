using SentMailProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.DTO
{
    public class MailDTO
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public AppUser SenderUser { get; set; }
        public AppUser ToWhoUser { get; set; }
        public bool SenderStarred { get; set; }
        public bool ToWhoStarred { get; set; }
        public bool ReadStatus { get; set; }

    }
}
