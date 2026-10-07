using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Dto.ServiceDtos
{
    public class CreateServiceDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
