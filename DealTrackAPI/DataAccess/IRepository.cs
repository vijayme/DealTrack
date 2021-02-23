using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealTrackAPI.Data
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetData();
        public void SaveData(string data);
    }
}
