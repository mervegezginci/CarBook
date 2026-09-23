using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Domain.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
