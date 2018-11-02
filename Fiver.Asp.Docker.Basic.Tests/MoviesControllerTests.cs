using Fiver.Asp.Docker.Basic.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Fiver.Asp.Docker.Basic.Tests
{
    public class MoviesControllerTests
    {
        [Fact(DisplayName = "Get_retruns_OkObjectResult_and_model")]
        public void Get_retruns_Ok_result_and_model()
        {
            // Arrange
            var sut = new MoviesController();

            // Act
            var result = sut.Get();

            // Assert
            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            var outputModel = Assert.IsType<string>(okObjectResult.Value);
            Assert.True(false);
        }
    }
}
