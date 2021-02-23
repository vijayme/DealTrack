using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DealTrackAPI.Models;
using DealTrackAPI.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DealTrackController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DealTrackController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<DealTrack>> GetAsync()

        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return await _mediator.Send(new DealTrackRequest());
        }

        [HttpPost]
        public async Task<HttpStatusCode> PostAsync([FromForm]object data)

        {
            return await _mediator.Send(new DealTrackPostRequest()
            {
                file = HttpContext.Request.Form.Files[0]
            });
        }
    }
}
