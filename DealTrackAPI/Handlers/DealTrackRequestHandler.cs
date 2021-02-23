using DealTrackAPI.Data;
using DealTrackAPI.Helpers.Decorators;
using DealTrackAPI.Models;
using DealTrackAPI.Request;
using Decor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;


namespace DealTrackAPI.Handlers
{
    public class DealTrackRequestHandler : IRequestHandler<DealTrackRequest, IEnumerable<DealTrack>>
    {
        private readonly DealTrackRepository _dealTrackRepository;

        public DealTrackRequestHandler(DealTrackRepository dealTrackRepository)
        {
            _dealTrackRepository = dealTrackRepository;
        }

        public async Task<IEnumerable<DealTrack>> Handle(DealTrackRequest request,
                                                   CancellationToken cancellationToken)
        {
            var decoratedService = new Decorator().For(_dealTrackRepository);
            return decoratedService.GetData().Result;
           // return _dealTrackRepository.GetData();
        }
    }
}
