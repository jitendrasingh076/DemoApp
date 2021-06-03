using DemoApp.Query;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class DemoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DemoController(IMediator mediator) {
            _mediator = mediator;
        }
       
        // GET api/<DemoController>/5
        [HttpGet]
        [Route("GetSeries/{number}")]
        public async Task <IActionResult> GetSeries(int number)
        {
            var queryReq = new SeriesQuery(number);
            var result = await _mediator.Send(queryReq);
            return Ok(result);
        }


        [HttpGet]
        [Route("GetSeriesDivisor/{divisor}/{number}")]
        public async Task<IActionResult> GetSeriesDivisor(int divisor,int number)
        {
            var queryReq = new SeriesDivisorQuery(divisor,number);
            var result = await _mediator.Send(queryReq);
            return Ok(result);
        }


    }
}
