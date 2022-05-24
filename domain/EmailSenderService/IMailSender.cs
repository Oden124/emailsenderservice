using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSenderService
{
    public interface IMailSender
    {
        void SendMail(IEnumerable<Email> emails, string thema, string mail);
    }
}
