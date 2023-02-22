using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class Todolists
    {
        public int TodolistId { get; set; }
        public string TodolistTitle { get; set; }
        public string TodolistExplanation { get; set; }
    }
}