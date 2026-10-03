using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Dto.AuthorDtos
{
    public class UpdateAuthorDto
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}