using SentMailProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Models.DTO
{
    public class SentMailAddModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string SenderUserEmail { get; set; }
        public string ToWhoUserEmail { get; set; }
    }
}
