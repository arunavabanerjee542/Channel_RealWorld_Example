using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeChannel
{
    interface IUploadVideo<T>
    {
        void Upload(T vedio);

        void VedioUploadCompleted();

    }
}
