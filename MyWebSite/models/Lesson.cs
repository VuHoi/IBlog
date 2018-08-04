using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.models
{
    public class Lesson
    {
       
       public Guid Id { get; set; }

        public string Title { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public string Content { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
