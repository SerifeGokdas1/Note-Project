using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class UserInformations
    {
        public int UserId { get; set; }
        public string UserNameSurname { get; set; }
        public string UserPassword { get; set; }
    }
}