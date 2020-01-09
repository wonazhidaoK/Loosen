using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Loosen.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Loosen.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Loosen.Web.Pages.LoosenPage
     */
    public abstract class LoosenPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<LoosenResource> L { get; set; }
    }
}
