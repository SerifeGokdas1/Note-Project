using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class User
    {
        [Required]
        public string UserNameSurname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}