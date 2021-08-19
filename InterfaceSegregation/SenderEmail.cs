using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class SenderEmail: INotefication
    {
        public void sendMail()
        {
            Console.WriteLine("Test Email Done!");
        }
    }

    public class SenderGmail:INotefication
    {
        public void sendMail()
        {
            Console.WriteLine("Test Gmail Done!");
        }
    }

    public class SenderHotmail: INotefication
    {
        public void sendMail()
        {
            Console.WriteLine("Test Hotmail Done!");
        }
    }
}
