using Loosen.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Loosen.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LoosenPageModel : AbpPageModel
    {
        protected LoosenPageModel()
        {
            LocalizationResourceType = typeof(LoosenResource);
        }
    }
}