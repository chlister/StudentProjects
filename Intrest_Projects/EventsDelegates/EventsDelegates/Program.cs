using EventsDelegates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.Title = "Vid1";

            VideoEncoder encoder = new VideoEncoder(); // Publisher

            MessageService messageService = new MessageService(); // Subscriber
            MailService service = new MailService(); // Subscriber
            // Here service subscribes to the VideoEncoded event
            encoder.VideoEncoded += service.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            encoder.Encode(video);

            Console.WriteLine("Done...");
            Console.ReadLine();

        }
    }
}
