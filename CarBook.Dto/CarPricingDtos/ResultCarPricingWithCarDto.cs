using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Dto.CarPricingDtos
{
    public class ResultCarPricingWithCarDto
    {
        public int CarPricingID { get; set; }
        public int CarID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int PricingID { get; set; }
        public string PricingName { get; set; }
        public decimal Amount { get; set; }
    }
}
