using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTagCloudsByBlogID(int id);
    }
}
