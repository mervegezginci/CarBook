using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Dto.TagCloudDtos
{
    public class GetByBlogIdTagCloudDto
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}
