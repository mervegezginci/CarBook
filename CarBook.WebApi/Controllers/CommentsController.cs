using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly CarBookContext _context;
        private readonly IGenericRepository<Comment> _commentsRepository;
        private readonly IMediator _mediator;

        public CommentsController(IGenericRepository<Comment> commentsRepository,IMediator mediator,CarBookContext context)
        {
            _commentsRepository = commentsRepository;
            _mediator = mediator;
            _context = context;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _context.Comments
                .Include(x => x.Blog)
                .Select(x => new
                {
                    x.CommentID,
                    x.Name,
                    x.Description,
                    x.CreatedDate,
                    x.BlogID,
                    BlogTitle = x.Blog.Title
                })
                .ToList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentsRepository.Create(comment);
            return Ok("Yorum başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentsRepository.GetById(id);
            _commentsRepository.Remove(value);
            return Ok("Yorum başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentsRepository.Update(comment);
            return Ok("Yorum başarıyla silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value = _commentsRepository.GetById(id);
            return Ok(value);
        }

        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var value = _commentsRepository.GetCommentsByBlogId(id);
            return Ok(value);
        }

        [HttpGet("CommentCountByBlog")]
        public IActionResult CommentCountByBlog(int id)
        {
            var value = _commentsRepository.GetCountCommentByBlog(id);
            return Ok(value);
        }

        [HttpPost("CreateCommentWithMediator")]
        public async Task<IActionResult> CreateCommentWithMediator(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yorum başarıyla eklendi");
        }

    }
}
