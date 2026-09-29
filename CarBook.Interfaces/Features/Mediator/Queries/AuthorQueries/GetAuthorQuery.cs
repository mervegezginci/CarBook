using CarBook.Application.Features.Mediator.Results.AuthorResults;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
