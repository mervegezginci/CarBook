using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
    }

}
