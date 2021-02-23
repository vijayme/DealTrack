using DealTrackAPI.Data;
using DealTrackAPI.Models;
using DealTrackAPI.Request;
using Decor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DealTrackAPI.Handlers
{
    public class DealTrackPostRequestHandler : IRequestHandler<DealTrackPostRequest, HttpStatusCode>
    {
        private readonly DealTrackRepository _dealTrackRepository;

        public DealTrackPostRequestHandler(DealTrackRepository dealTrackRepository)
        {
            _dealTrackRepository = dealTrackRepository;
        }

        public Task<HttpStatusCode> Handle(DealTrackPostRequest request, CancellationToken cancellationToken)
        {
            _dealTrackRepository.SaveData(request.file);
            return Task.FromResult(HttpStatusCode.OK);
        }
    }
}
