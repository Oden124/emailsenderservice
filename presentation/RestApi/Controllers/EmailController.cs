using EmailSenderService;
using Microsoft.AspNetCore.Mvc;
using RestApi.Models;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;
        public EmailController(IEmailService emailService)
        {
            if (emailService == null) throw new ArgumentNullException(nameof(emailService));

            this.emailService = emailService;
        }

        [HttpPost(Name = "SendEmail")]
        public Response SendEmails(string messText)
        {   
            emailService.SendEmails(messText);

            //Пока всегда возвращается положительный статус, нужно обработать ошибки
            return new Response {Status = 1, Description = "Success" };
        }
    }
}
