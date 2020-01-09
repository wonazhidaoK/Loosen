using System;
using System.Collections.Generic;
using System.Text;
using Loosen.Localization;
using Volo.Abp.Application.Services;

namespace Loosen
{
    /* Inherit your application services from this class.
     */
    public abstract class LoosenAppService : ApplicationService
    {
        protected LoosenAppService()
        {
            LocalizationResource = typeof(LoosenResource);
        }
    }
}
