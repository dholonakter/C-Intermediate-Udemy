using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class StackOverflow
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Counter { get; private set; }
        public StackOverflow(string ttile, string description, DateTime createdAt)
        {
            this.Title = ttile;
            this.Description = description;
            this.CreatedAt = createdAt;
        }
        public void UpVote()
        {
            Counter++;
        }
        public void DownVote()
        {
            Counter--;

        }
    }
}
