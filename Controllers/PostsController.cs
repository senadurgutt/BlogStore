using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Abstrac;
using WebApplication1.Data.Concrete.EfCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _postrepository;
        private ITagRepository _tagrepository;
        public PostsController(IPostRepository postrepository, ITagRepository tagrepository)
        {
            _postrepository = postrepository;
            _tagrepository = tagrepository;
        }
        public IActionResult Index()
        {
            return View(
                new PostsViewModel
                {
                    Posts = _postrepository.Posts.ToList(),
                }
                );
        }
    }
}
