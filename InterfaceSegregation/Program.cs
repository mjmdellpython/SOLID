using System;

namespace InterfaceSegregation
{


    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Notefications n = new Notefications();
            //n.Emailnotification();

            Notefications nt = new Notefications(new SenderGmail());

            nt.sendMail();
        }
    }
}
