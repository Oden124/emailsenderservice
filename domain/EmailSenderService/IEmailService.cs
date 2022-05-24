using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderService
{
    public interface IEmailService
    {
        void SendEmails(string mailText);
    }
}
