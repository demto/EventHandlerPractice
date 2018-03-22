using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerPractice {
    class VideoEncoder {

        public event EventHandler<EventArgs> VideoEncoded;

        public void Encode(Video video){
            Console.WriteLine("Video is encoded!");

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video vid){
            VideoEncoded?.Invoke(this, new EventArgs());
        }
    }
}
