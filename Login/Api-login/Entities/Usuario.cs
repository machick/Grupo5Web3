using System;
using System.Collections.Generic;

namespace Api_login.Entities
{
    public partial class Usuario
    {
        public int IdUser { get; set; }
        public string User { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
    }
}
