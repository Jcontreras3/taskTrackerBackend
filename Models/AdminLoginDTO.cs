using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskTrackerBackend.Models
{
    public class AdminLoginDTO
    {
        public int adminId { get; set; }

        public string? adminUsername { get; set; }
        public string? Salt { get; set; }
        public string? Hash { get; set; }
    }
}