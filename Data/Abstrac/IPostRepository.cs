using WebApplication1.Entity;

namespace WebApplication1.Data.Abstrac
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }

        void CreatePost(Post post);
    }
}
