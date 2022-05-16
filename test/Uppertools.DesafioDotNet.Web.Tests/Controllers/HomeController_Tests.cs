using System.Threading.Tasks;
using Uppertools.DesafioDotNet.Models.TokenAuth;
using Uppertools.DesafioDotNet.Web.Controllers;
using Shouldly;
using Xunit;

namespace Uppertools.DesafioDotNet.Web.Tests.Controllers
{
    public class HomeController_Tests: DesafioDotNetWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}