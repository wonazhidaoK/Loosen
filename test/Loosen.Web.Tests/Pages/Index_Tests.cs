using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Loosen.Pages
{
    public class Index_Tests : LoosenWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
