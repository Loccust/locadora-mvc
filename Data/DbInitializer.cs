using System;
using System.Linq;
using VideoStore.Model;
namespace VideoStore.Data
{
    public class DbInitializer
    {
        public static void Initialize(VideoStoreDbContext context)
        {
            context.Database.EnsureCreated();
            InitializeUsers(context);
            InitializeCategories(context);
            InitializeMovies(context);
        }
        private static void InitializeUsers(VideoStoreDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{
                    Name="Locadora Tatooine",
                    CreationDate=DateTime.Now,
                    CEP="13041150",
                    Street="Rua Dr Angêlo Simões",
                    Number=189,
                    Complement="",
                    Document="02240374000100",
                    Phone="1999999999",
                    Email="email@test.com",
                },
                new User{
                    Name="Locadora Mando",
                    CreationDate=DateTime.Now,
                    CEP="13041150",
                    Street="Rua Dr Angêlo Simões",
                    Number=189,
                    Complement="",
                    Document="53740878000120",
                    Phone="1999999999",
                    Email="email@test.com"
                },
            };

            foreach (var user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
        private static void InitializeCategories(VideoStoreDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
            {
                new Category{
                    Description="Action",
                },
                new Category{
                    Description="Scary",
                },
                new Category{
                    Description="Adventure",
                }
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();
        }

        private static void InitializeMovies(VideoStoreDbContext context)
        {
            if (context.Movies.Any())
            {
                return;
            }

            var movies = new Movie[]
            {
                new Movie{
                    Title="Fast and Furious",
                    Image="",
                    CategoryId=1,
                    RegisteredDate=DateTime.Now,
                },
                new Movie{
                    Title="Fast and Furious",
                    Image="",
                    CategoryId=1,
                    RegisteredDate=DateTime.Now,
                },
            };

            foreach (var movie in movies)
            {
                context.Movies.Add(movie);
            }
            context.SaveChanges();
        }
    }

}
