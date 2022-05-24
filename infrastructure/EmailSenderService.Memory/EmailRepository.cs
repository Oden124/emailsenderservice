using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmailSenderService.Memory
{
    //Класс имитирующий реальное хранилище данных
    public class EmailRepository : IEmailRepository
    {
        //Заполнить циклом 5000000 записей
        private List<Email> emails;

        public IEnumerable<Email> GetAll()
        {
            emails = new List<Email>();

            for (int i = 1; i <= 5000000; i++)
            {
                emails.Add(new Email(i, "mailaddr" + i + "@gmail.com"));
            }

            return emails;
        }
    }
}
