using System;

namespace Event_n_Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending a Text message...." +args.Video.Title);
        }
        
    } 
}
