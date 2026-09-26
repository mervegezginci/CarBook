using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
    {
        public int FooterAddressId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
