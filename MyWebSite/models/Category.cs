using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.models
{
    public class Category
    {
      public  Guid Id { get; set; }
      
        public  string Title { get; set; }
        public string Detail { get; set; }

    }
}
