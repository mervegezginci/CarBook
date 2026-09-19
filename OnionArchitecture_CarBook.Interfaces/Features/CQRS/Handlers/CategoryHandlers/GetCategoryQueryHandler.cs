using OnionArchitecture_CarBook.Application.Features.CQRS.Results.CategoryResults;
using OnionArchitecture_CarBook.Application.Interfaces;
using OnionArchitecture_CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryID=x.CategoryID,
                Name = x.Name
            }).ToList();
        }
    }
}
