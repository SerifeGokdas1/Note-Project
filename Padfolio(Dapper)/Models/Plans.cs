using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class Plans
    {
        public int PlanId { get; set; }
        public string PlanTitle { get; set; }
        public string PPrice { get; set; }
        public string PExplanation { get; set; }
    }
}