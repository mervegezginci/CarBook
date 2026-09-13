using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}
