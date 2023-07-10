using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurations
{
    public class DomainManager : IDomainService
    {
        private IConfiguration _configuration;

        public DomainManager(IConfiguration configuration)
        {
            _configuration=configuration;
        }

        public string Domain()
        {
            string host = _configuration.GetSection("AllowedHosts").Value;
            return host;
        }
    }
}
