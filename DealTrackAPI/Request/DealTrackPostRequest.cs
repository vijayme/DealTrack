using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DealTrackAPI.Request
{
    public class DealTrackPostRequest : IRequest<HttpStatusCode>
    {
        public IFormFile file {get;set;}
    }

}
