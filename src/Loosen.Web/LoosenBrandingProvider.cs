using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Loosen.Web
{
    [Dependency(ReplaceServices = true)]
    public class LoosenBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Loosen";
    }
}
