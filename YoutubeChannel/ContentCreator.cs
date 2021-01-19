using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeChannel
{
    class ContentCreator
    {
        List<string> someDummyContents = new List<string>()
        {
            "Educational" , "Ds & Algo" , "Roasting" , "Web Series"
        };

        public async Task UploadVedio(IUploadVideo<string> creator)
        {
            
            foreach (var content in someDummyContents)
            {
                await Task.Delay(1000);
                creator.Upload(content);
            }

        }


    }
}
