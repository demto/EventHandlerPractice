using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerPractice {
    class VideoEventArgs : EventArgs{

        public VideoEventArgs(Video video){
            Video = video;
        }

        public Video Video { get; set; }
    }
}
