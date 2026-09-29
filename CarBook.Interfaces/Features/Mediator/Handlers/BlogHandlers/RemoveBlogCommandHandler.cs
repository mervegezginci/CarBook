using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Blogs.Mediator.Handlers.BlogHandlers
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand>
    {
        private readonly IRepository<Blog> _repository;
        public RemoveBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            await _repository.RemoveAsync(value);

            return Unit.Value;
        }
    }
}

