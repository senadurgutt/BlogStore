using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Abstrac;
using WebApplication1.Data.Concrete.EfCore;
using WebApplication1.Entity;

namespace WebApplication1.ViewComponents
{
    public class NewPosts: ViewComponent
    {
        private IPostRepository _postRepository;

        public NewPosts(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await
                _postRepository.Posts.OrderByDescending(p => p.PublishedOn).Take(5).ToListAsync());
        }
    }
}
