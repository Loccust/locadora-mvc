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
                    Sinopse=@"Após os acontecimentos em Londres, Dom, Brian,
                    Letty e o resto da equipe têm a chance de voltar para os Estados Unidos
                     e recomeçar suas vidas. Mas a tranquilidade do grupo é destruída quando
                     Deckard Shaw, um assassino profissional, quer vingança pelo acidente que 
                     deixou seu irmão em coma. Agora, a equipe tem de unir forças para deter 
                     um vilão novo e ainda mais perigoso. Dessa vez, não se trata apenas de 
                     uma questão de velocidade: a corrida é pela sobrevivência.",
                    Image="https://images-na.ssl-images-amazon.com/images/I/910VekmDZ5L._AC_SY741_.jpg",
                    CategoryId=1,
                    Duration="2h 02min"
                },
                new Movie{
                    Title="Percy Jackson e o ladrão de raios",
                    Image="https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTbuNSWg8q9dnyCXFgu9zWETElvyGVGpbSvLkZAXeNJ9veGBffx",
                    Sinopse=@"A vida do adolescente Percy Jackson, que está sempre pronto 
                    para entrar em uma confusão, torna-se bem mais complicada quando ele 
                    descobre que é filho do deus grego Poseidon. Em um campo de treinamento 
                    para filhos das divindades, Percy aprende a tirar proveito de seus poderes 
                    divinos e se preparea para a maior aventura de sua vida.",
                    CategoryId=2,
                    Duration="1h 49min"
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
