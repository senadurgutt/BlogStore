﻿using WebApplication1.Data.Abstrac;
using WebApplication1.Entity;

namespace WebApplication1.Data.Concrete.EfCore
{
    public class EfTagRepository : ITagRepository
    {
        private BlogContext _context;
        public EfTagRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Tag> Tags => _context.Tags;

        public void CreateTag(Tag Tag)
        {
            _context.Tags.Add(Tag);
            _context.SaveChanges();
        }
    }
}
