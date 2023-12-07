using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sweepers_Dev.Shared
{
    public class UserRole
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}