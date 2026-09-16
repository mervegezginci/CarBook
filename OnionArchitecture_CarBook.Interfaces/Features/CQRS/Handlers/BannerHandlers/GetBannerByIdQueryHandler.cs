using OnionArchitecture_CarBook.Application.Features.CQRS.Queries.BannerQueries;
using OnionArchitecture_CarBook.Application.Features.CQRS.Results.BannerResults;
using OnionArchitecture_CarBook.Application.Interfaces;
using OnionArchitecture_CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerID=values.BannerID,
                Title = values.Title,
                Description=values.Description,
                VideoUrl = values.VideoUrl,
                VideoDescription=values.VideoDescription
            };
        }
    }
}
