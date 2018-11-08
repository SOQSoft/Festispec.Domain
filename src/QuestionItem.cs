using System;
using System.Collections.Generic;

namespace Festispec.Database.Models
{
    public partial class QuestionItem
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int? QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
