using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates.Model
{
    public class MailService
    {
        // 1 - Define a eventhandler - that corrosponds to the delegate in VideoEncoder
        

        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: sending an email... " + args.Video.Title);
        }
    }
}
