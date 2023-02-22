using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class AdminInformations
    {
        public int AdminId { get; set; }
        public string AdminNameSurname { get; set; }
        public string AdminPassword { get; set; }
    }
}