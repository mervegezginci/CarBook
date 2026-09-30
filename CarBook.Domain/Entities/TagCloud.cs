using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Domain.Entities
{
    public class TagCloud
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
