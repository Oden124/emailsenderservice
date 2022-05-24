using System;

namespace EmailSenderService
{
    //Сущность, определяющая запись в хранилище почтовых адресов 
    public class Email
    {
        public int Id { get; }
        public string Address { get; }
        
        public Email(int id, string address)
        {
            Id = id;
            Address = address;
        }

    }
}
