

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageMenager _messageDal = new WriterMessageMenager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userMenager;

        public MessageController(UserManager<WriterUser> userMenager)
        {
            _userMenager = userMenager;
        }

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _messageDal.GetListReceiverMessage(p);

            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _messageDal.GetListSenderMessage(p);

            return View(messageList);
        }
        [Route("ReceiverMessageDetail/{id}")]
        public IActionResult ReceiverMessageDetail(int id)
        {
            WriterMessage writerMessage = _messageDal.GetById(id);
            return View(writerMessage);
        }
        [Route("SenderMessageDetail/{id}")]
        public IActionResult SenderMessageDetail(int id)
        {
            WriterMessage writerMessage = _messageDal.GetById(id);
            return View(writerMessage);
        }

        [HttpGet]
        [Route("")]
        [Route("AddMessage")]
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("AddMessage")]
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
