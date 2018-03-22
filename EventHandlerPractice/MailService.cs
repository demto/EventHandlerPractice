using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerPractice {
    class MailService {

        public void OnVideoEncoded(object source, EventArgs e){
            Console.WriteLine("Mail sent!");
        }
    }
}
