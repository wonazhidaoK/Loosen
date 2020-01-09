using Loosen.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Loosen.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LoosenController : AbpController
    {
        protected LoosenController()
        {
            LocalizationResource = typeof(LoosenResource);
        }
    }
}