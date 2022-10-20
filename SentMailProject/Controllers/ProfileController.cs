using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SentMailProject.Models.Context;
using SentMailProject.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentMailProject.Controllers
{
    public class ProfileController : Controller
    {
        Context context = new Context();


        readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ActionResult> Index()
        {
            SentMailModel sentMailModel = new SentMailModel();

            sentMailModel.appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            sentMailModel.senderMails = context.SentMails.Where(x => x.Sender.AppUserID == sentMailModel.appUser.Id).Select(x => new MailDTO
            {
                Id = x.ID,
                Subject = x.Subject,
                Message = x.Message,
                Date = x.Date,
                SenderUser = context.Users.Where(y => y.Id == x.Sender.AppUserID).FirstOrDefault(),
                ToWhoUser = context.Users.Where(y => y.Id == x.ToWho.AppUserID).FirstOrDefault(),
                SenderStarred = x.SenderStarred,
                ToWhoStarred = x.ToWhoStarred,
                ReadStatus = x.ReadStatus
            }).ToList();
            sentMailModel.toWhosMails = context.SentMails.Where(x => x.ToWho.AppUserID == sentMailModel.appUser.Id).Select(x => new MailDTO
            {
                Id = x.ID,
                Subject = x.Subject,
                Message = x.Message,
                Date = x.Date,
                SenderUser = context.Users.Where(y => y.Id == x.Sender.AppUserID).FirstOrDefault(),
                ToWhoUser = context.Users.Where(y => y.Id == x.ToWho.AppUserID).FirstOrDefault(),
                SenderStarred = x.SenderStarred,
                ToWhoStarred = x.ToWhoStarred,
                ReadStatus = x.ReadStatus

            }).ToList();
            sentMailModel.starMails = context.SentMails.Where(x => (x.SenderStarred == true || x.ToWhoStarred == true) && (x.SenderID == sentMailModel.appUser.Id || x.ToWhoID == sentMailModel.appUser.Id)).Select(x => new MailDTO
            {
                Id = x.ID,
                Subject = x.Subject,
                Message = x.Message,
                Date = x.Date,
                SenderUser = context.Users.Where(y => y.Id == x.Sender.AppUserID).FirstOrDefault(),
                ToWhoUser = context.Users.Where(y => y.Id == x.ToWho.AppUserID).FirstOrDefault(),
                SenderStarred = x.SenderStarred,
                ToWhoStarred = x.ToWhoStarred,
                ReadStatus = x.ReadStatus
            }).ToList();
            return View(sentMailModel);
        }

        public async Task<IActionResult> MailDetail(int id)
        {
            SentMailDTO sentMailDTO = new SentMailDTO();
            sentMailDTO.sentMail = context.SentMails.Where(x => x.ID == id).FirstOrDefault();
            sentMailDTO.sender = context.Users.Where(x => x.Id ==context.Senders.Where(y=> y.ID == sentMailDTO.sentMail.SenderID).FirstOrDefault().AppUserID).FirstOrDefault();
            sentMailDTO.toWho = context.Users.Where(x => x.Id == context.ToWhos.Where(y => y.ID == sentMailDTO.sentMail.ToWhoID).FirstOrDefault().AppUserID).FirstOrDefault();
            sentMailDTO.appUser= await _userManager.FindByNameAsync(User.Identity.Name);
            return View(sentMailDTO);
        }

        [HttpGet]
        public async Task<IActionResult> AddMail()
        {
            SentMailAddModel sentMailAddModel = new SentMailAddModel();
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            sentMailAddModel.SenderUserEmail = appUser.Email; 

            return View(sentMailAddModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddMail(SentMailAddModel sentMailAdd)
        {
            SentMailAddModel sentMailAddModel = new SentMailAddModel();
            //ilk olarak towhoMAil bizim sistemde kayıtlı bir kullanıcı mı bunu kontrol etcez. varsa appuserID sini alcaz.
            //senderEmailden appuserIDsini alcaz.

            // towhoAppUserID ile toWhos tablosuna kayıt atcaz. buradan bize id dönecek.
            // senderAppUserID ile senders tablosuna kayıt atcaz. buradan id dönecek.

            return View();
        }

    }
}
