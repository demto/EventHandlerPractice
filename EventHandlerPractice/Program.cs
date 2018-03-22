using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerPractice {
    class Program {
        static void Main(string[] args) {

            var encoder = new VideoEncoder();
            var vid = new Video { Title = "Greatest Moie" };
            var mailService = new MailService();

            encoder.VideoEncoded += mailService.OnVideoEncoded;

            encoder.Encode(vid);

            Console.ReadKey();
        }
    }
}
