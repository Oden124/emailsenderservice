using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderService
{
    //Сервис, определяющий общую логику отправки сообщений
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository emailRepository;
        private readonly IMailSender mailSender;

        //В конструкторе внедряем зависимости хранилища данных и компонент отправки сообщений
        public EmailService(IEmailRepository emailRepository, IMailSender mailSender)
        {
            if (emailRepository == null) throw new ArgumentNullException(nameof(emailRepository));
            if (mailSender == null) throw new ArgumentNullException(nameof(mailSender));

            this.emailRepository = emailRepository;
            this.mailSender = mailSender;
        } 

        public void SendEmails(string mailText)
        {
            //Получаем кололекцию адресов
            IEnumerable<Email> emails = emailRepository.GetAll();
            
            //Делаем рассылку сообщения по всем адресам
            mailSender.SendMail(emails, "Массовая рассылка", mailText);
        }
    }
}
