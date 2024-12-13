using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Abstrac;
using WebApplication1.Data.Concrete.EfCore;

namespace WebApplication1.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _repository;
        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Posts.ToList());
        }
    }
}
