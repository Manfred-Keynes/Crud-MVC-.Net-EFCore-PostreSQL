using System;
using System.Collections.Generic;

namespace PostgreSQLEF.Models.DB
{
    public partial class Usuarios
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTimeOffset? Date { get; set; }
    }
}
