using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Notefications
    {
        private readonly INotefication _Inote;

        public Notefications(INotefication Inote)
        {
            _Inote = Inote;
        }

        public void sendMail()
        {
            _Inote.sendMail();
        }


        /* old version */
        //SenderEmail e = new SenderEmail();
        //SenderGmail g = new SenderGmail();
        //SenderHotmail h = new SenderHotmail();
        //public void Emailnotification()
        //{
        //    e.sendEmail();
        //}

        //public void Gmailnotification()
        //{
        //    g.sendEmail();
        //}

        //public void Hotmailnotification()
        //{
        //    h.sendEmail();
        //}
    }
}
