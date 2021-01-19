using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeChannel
{
    class ContentValidator
    {

        public async Task ValidateContent(IValidateVedio<string> validator)
        {
            while (true)
            {
                await validator.Validate();
            }

        }


    }
}
