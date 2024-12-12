using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.Data.Concrete.EfCore
{
    public static class SeedData
    {

        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();
            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if (!context.Tags.Any()) {
                    context.Tags.AddRange(
                        new Tag { Text = "web programlama" },
                        new Tag { Text = "backend" },
                        new Tag { Text = "frontend" },
                        new Tag { Text = "fullstack" }
                    );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(

                        new User { UserName = "Sena Durgut"},
                        new User { UserName = "Sena Durgut"},
                        new User { UserName = "Sena Durgut"}
                        );
                    context.SaveChanges();

                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(

                        new Post
                        {
                            Title = "ASP.Net Core",
                            Content = "ASP.Net Core Dersleri",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1
                        },
                        new Post
                        {
                            Title = "Dart",
                            Content = "Flutter Dersleri",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-2),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        },
                        new Post
                        {
                            
                            Title = "PHP",
                            Content = "PHP Dersleri",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-8),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 3
                        }
                        );
                    context.SaveChanges(); // veritabanına ekleniyor

                } 
            }
        }
    }
}
