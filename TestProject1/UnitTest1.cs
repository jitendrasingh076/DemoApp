using DemoApp.Controllers;
using DemoApp.Query;
using DemoApp.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private Mock<IMediator> mediator;

        public UnitTest1() {
            mediator = new Mock<IMediator>();
        }
        [Fact]
        public void SeriesDivisorTest()
        {
            mediator.Setup(x => x.Send(It.IsAny<SeriesDivisorQuery>(), new System.Threading.CancellationToken())).
                ReturnsAsync(new List<SeriesDivisorResponse>());

            var democtrl = new DemoController(mediator.Object);
            var result = democtrl.GetSeriesDivisor(3,15);
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
