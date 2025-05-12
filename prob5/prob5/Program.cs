/*
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Notification
    {
        private EmailService emailService = new EmailService();
        public void Alert(string message)
        {
            emailService.Send(message);
        }
    }
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace prob5
{
   
    public interface IMessageService
    {
       void Send(string message);
    }

    public class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Notification
    {
        private readonly IMessageService _messageService;
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Alert(string message)
        {
            _messageService.Send(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageService emailService = new EmailService();

            var notification = new Notification(emailService);

            notification.Alert("hello");
        }
    }
}
