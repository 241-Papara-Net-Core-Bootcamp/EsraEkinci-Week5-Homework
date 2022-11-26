using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Services.Configurations
{
    public class CacheConfiguration
    {
        public int AbsoluteExpirationInHours { get; set; }
        public int SlidingExpirationInMinutes { get; set; }
    }
}
