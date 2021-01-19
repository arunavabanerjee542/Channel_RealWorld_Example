using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeChannel
{
    interface IValidateVedio<T>
    {

        Task<T> Validate();

        bool IsContentAvailable();


    }
}
