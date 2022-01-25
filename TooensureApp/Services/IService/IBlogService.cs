using System.Collections.Generic;
using TooensureApp.Models.BlogModel;

namespace TooensureApp.Services.IService
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> Blogs { get; set; }
    }
}