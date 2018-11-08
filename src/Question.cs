using System;
using System.Collections.Generic;

namespace Festispec.Database.Models
{
    public partial class Question
	{
		public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int QuestionType { get; set; }
        public int? FormId { get; set; }

        public Form Form { get; set; }
        public ICollection<QuestionItem> QuestionItem { get; set; } = new List<QuestionItem>();
	}
}
