using Decor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealTrackAPI.Helpers.Decorators
{
    public class PriceDecorator : IDecorator
    {
        private const string currencyText = "CAD$";
        public async Task OnInvoke(Call call)
        {
            await call.Next();
            ((List<Models.DealTrack>)call.ReturnValue).ForEach(item => { item.Price = currencyText + item.Price; });
        }
    }
}
