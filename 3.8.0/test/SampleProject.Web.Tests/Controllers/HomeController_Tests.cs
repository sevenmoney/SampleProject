using System.Threading.Tasks;
using SampleProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace SampleProject.Web.Tests.Controllers
{
    public class HomeController_Tests: SampleProjectWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
