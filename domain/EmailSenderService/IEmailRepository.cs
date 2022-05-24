using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderService
{
    public interface IEmailRepository
    {
        IEnumerable<Email> GetAll();
    }
}
