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
            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{
                    UserId=1,
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
                    UserId=2,
                    Name="Locadora Mando",
                    CreationDate=DateTime.Now,
                    CEP="13041150",
                    Street="Rua Dr Angêlo Simões",
                    Number=189,
                    Complement="",
                    Document="02240374000100",
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
    }
}
