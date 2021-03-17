using System;
using System.Threading;

namespace Event_n_Delegates
{
    
        public class VideoEventArgs : EventArgs
        {
            public Video Video { get; set; }
        }
        public class VideoEncoder
        {
            
            // 1- Define a Delegate
            // 2- Define an Event based on that Delegate
            // 3- Raise the event

            public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // delegate defined

        //public event VideoEncodedEventHandler VideoEncoded; //Event defined based on delegate

            public event EventHandler<VideoEventArgs> VideoEncoded;

            public void Encode(Video video)
            {
                Console.WriteLine("Video encoding...");
                Thread.Sleep(3000);

                OnVideoEncoded(video);
            }

            protected virtual void OnVideoEncoded(Video video) //raise the event
            {
                if (VideoEncoded != null)
                    VideoEncoded(this, new VideoEventArgs() {Video = video});
            }
        
        }
}
