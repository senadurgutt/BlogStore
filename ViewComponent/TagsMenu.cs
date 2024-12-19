using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Abstrac;
using WebApplication1.Data.Concrete.EfCore;
using WebApplication1.Entity;

namespace WebApplication1.Components
{
    public class TagsMenu:ViewComponent
    {
        private readonly ITagRepository _tagRepository;

        public TagsMenu(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _tagRepository.Tags.ToListAsync());
        }

    }
}
