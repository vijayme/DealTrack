using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealTrackAPI.Models;

namespace DealTrackAPI.Request
{
    public class DealTrackRequest : IRequest<IEnumerable<DealTrack>> { }
}
