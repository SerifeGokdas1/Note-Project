using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class Admin
    {
        [Required]
        public string AdminNameSurname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string AdminPassword { get; set; }

    }
}