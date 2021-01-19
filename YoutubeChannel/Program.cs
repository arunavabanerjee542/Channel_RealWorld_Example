using System;
using System.Threading.Tasks;

namespace YoutubeChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            ContentCreator creator = new ContentCreator();
            ContentValidator validator = new ContentValidator();
            Channel<string> channel = new Channel<string>();

            Task.WaitAll(creator.UploadVedio(channel), validator.ValidateContent(channel));
               

            Console.ReadLine();


        }
    }
}
