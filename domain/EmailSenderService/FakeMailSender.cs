using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace EmailSenderService
{
    //Класс имитирующий рассылку сообщений по переданным адресам, записью в файл
    public class FakeMailSender : IMailSender
    {
        public void SendMail(IEnumerable<Email> emails, string thema, string mailtext)
        {
            object locker = new Object();  // заглушка
            string path = "d:/messages.txt";
            string text;

            var sw = new Stopwatch();

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                Parallel.ForEach<Email>(emails, (email) =>
                {
                    lock(locker)
                    {
                        text = "# " + email.Id + "\n" + 
                               "Адрес:\n" + email.Address + 
                               "\nТема:" + thema + 
                               "\nСообщение:" + mailtext;
                        writer.WriteLine(text);
                    }
                });
            }
        }
    }
}
