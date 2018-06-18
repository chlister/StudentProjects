using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsDelegates.Model
{
    // Custom eventargs for sending information with eventargs
    public class VideoEventArgs : EventArgs
    {
        // This is the information we want to send
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

            // This holds a reference to a method that looks exactly like this
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public VideoEncoder()
        {

        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(3000);
            
            // Here we raise the event in the method
            OnVideoEncoded(video);
        }

        // In .NET the convention is that events sould be:
        // Protected
        // Virtual
        // Void
        // And always append "On" + Name of event
        protected virtual void OnVideoEncoded(Video video)
        {
            // This way is just fine but it can be shortened by using the nullable char (?)
           /*  
              if (VideoEncoded != null)
                {
                    VideoEncoded.Invoke(this, EventArgs.Empty);
                }
            */
            // Here we used the nullable keyword (?)
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video});
        }
    }
}
