using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Domain.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
