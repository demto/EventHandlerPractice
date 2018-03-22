using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerPractice {
    class MessageService {

        public void OnVideoEncoded(object source, VideoEventArgs e){
            Console.WriteLine($"Message has been sent too about {e.Video.Title}");
        }
    }
}
