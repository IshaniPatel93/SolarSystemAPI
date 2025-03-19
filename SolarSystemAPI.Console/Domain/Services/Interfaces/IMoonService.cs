using SolarSystemAPI.ConsoleApp.Domain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemAPI.ConsoleApp.Domain.Services.Interfaces
{
    ///<summary>
    /// A service that can be used to get data from the Solar System OpenData API<see href="https://api.le-systeme-solaire.net/"/>. 
    ///</summary>
    public interface IMoonService
    {
        IEnumerable<Moon> GetAllMoons();
    }
}
