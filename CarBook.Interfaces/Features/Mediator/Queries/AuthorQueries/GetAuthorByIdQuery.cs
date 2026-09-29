using CarBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
