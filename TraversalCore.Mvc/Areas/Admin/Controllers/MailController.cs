using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCore.Mvc.Models;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(MailRequest mailRequest)  //mailRequest sınıfını dahil ettik
        {
            MimeMessage mimeMessage = new MimeMessage();        
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "fatihsaridag26@gmail.com");    //Kimden gönderilecek ? 
            mimeMessage.From.Add(mailboxAddressFrom);   //Mailin yukarıdaki kullanıcıdan geldiğini belirtmiş olduk.
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);   //Mailbox kime gönderilecek.
            mimeMessage.To.Add(mailboxAddressTo);     //Mailin yukarıdaki kişiye gönderileceği belirtildi.
            var bodyBuilder = new BodyBuilder();      //BodyBuilder isimli bir sınıf oluşturuldu     
            bodyBuilder.TextBody = mailRequest.Body;  //mailRequestten gelen Body i oluşturdugumuz sınıf içindeki Bodye attık.
            mimeMessage.Body = bodyBuilder.ToMessageBody();     //Body mesajının ne oldugunu mimeMessage.Body içine attık.
            mimeMessage.Subject = mailRequest.Subject;          //Konu mesajının ne oldugunu mimeMessage Subject içine attık.
            SmtpClient client = new SmtpClient();               //SmtpClient sınıfından bir nesne türettik. (mailkit.net kütüphanesi ekledik.)
            client.Connect("smtp.gmail.com", 587, false);       //gmaille çalıştığımız için buraya gitti.
            client.Authenticate("fatihsaridag26@gmail.com", "adgaiqxktaqhtoog");    //Google dan doğrulama işlemi gerçekleştirdik şifre alarak
            client.Send(mimeMessage);           //mimeMessage ı gönderdik.
            client.Disconnect(true);            
            return View();
            
        }
    }
}

//traversalcore2@gmail.com