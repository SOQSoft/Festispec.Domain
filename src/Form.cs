using System;
using System.Collections.Generic;

namespace Festispec.Database.Models
{
    public partial class Form
    {       
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTemplate { get; set; }
        public string Comments { get; set; }
		public ICollection<Question> Question { get; set; } = new List<Question>();
    }
}
