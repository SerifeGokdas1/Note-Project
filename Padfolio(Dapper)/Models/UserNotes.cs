using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padfolio_Dapper_.Models
{
    public class UserNotes
    {
        public int UserNoteId { get; set; }
        public string UserNoteTitle { get; set; }
        public string UserNoteExplanation { get; set; }
    }
}