

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class MessageController : Controller
    {
        WriterMessageMenager _messageDal = new WriterMessageMenager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userMenager;

        public MessageController(UserManager<WriterUser> userMenager)
        {
            _userMenager = userMenager;
        }

        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _messageDal.GetListReceiverMessage(p);

            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _messageDal.GetListSenderMessage(p);

            return View(messageList);
        }


        public IActionResult ReceiverMessageDetail(int id)
        {
            WriterMessage writerMessage = _messageDal.GetById(id);
            return View(writerMessage);
        }

        public IActionResult SenderMessageDetail(int id)
        {
            WriterMessage writerMessage = _messageDal.GetById(id);
            return View(writerMessage);
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(WriterMessage p)
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var username=c.Users.Where(x=>x.Email==p.Receiver).Select(y=>y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverNAme = username;
            _messageDal.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
