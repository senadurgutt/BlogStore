using WebApplication1.Entity;

namespace WebApplication1.Data.Abstrac
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }

        void CreateTag(Tag tag);
    }
}
