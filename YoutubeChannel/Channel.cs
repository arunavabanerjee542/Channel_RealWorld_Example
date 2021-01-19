using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YoutubeChannel
{
    class Channel<T> : IUploadVideo<T> , IValidateVedio<T>
    {
        private readonly ConcurrentQueue<T> _listOfContents;
        private readonly SemaphoreSlim _coordinator;

        public Channel()
        {
            _listOfContents = new ConcurrentQueue<T>();
            _coordinator = new SemaphoreSlim(0);
        }

      

        public void Upload(T vedio)
        {
            _listOfContents.Enqueue(vedio);
            Console.WriteLine(" Creator has uploaded " + vedio);
            _coordinator.Release();
            Console.WriteLine(vedio + " can now be validated ");
        }

        public async Task<T> Validate()
        {
            Console.WriteLine(" waiting for content ");
            await _coordinator.WaitAsync();

            
             _listOfContents.TryDequeue(out T content);

            Console.WriteLine(" Got " + content +" to validate ");

            return content;
            
        }

        public void VedioUploadCompleted()
        {
            throw new NotImplementedException();
        }

        public bool IsContentAvailable()
        {
            throw new NotImplementedException();
        }
    }
}
