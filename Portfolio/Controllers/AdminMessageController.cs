using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageMenager wm = new WriterMessageMenager(new EfWriterMessageDal());
        public IActionResult SendBox()
        {
            string p = "gozgirfaruk@gmail.com";
            var values = wm.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult SendDetail(int id)
        {
            var values = wm.GetById(id);
            return View(values);
        }

        public IActionResult Inbox()
        {
            string p = "gozgirfaruk@gmail.com";
            var values = wm.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult ReceiverDetail(int id)
        {
            return View(wm.GetById(id));
        }

        [HttpGet]
        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(WriterMessage mess)
        {
            mess.Date = DateTime.Now;
            mess.Sender = "ÖFG";
            mess.SenderName = "ÖFG";
            wm.TAdd(mess);
            return RedirectToAction("SendBox");
        }
    }
}
