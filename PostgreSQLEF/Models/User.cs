using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSQLEF.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
    }
}
