using HotelLibrary.DBContex;
using HotelLibrary.Models;

namespace CustomerWebApp
{
    public class CustomerFunction
    {
        public void RegisterCustomer(string email, string name, string password)
        {
            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.Email == email))
                {
                    throw new InvalidOperationException("A user with this email already exists.");
                }

                var newUser = new User
                {
                    Email = email,
                    Name = name,
                    Password = password
                };

                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public bool LoginCustomer(string email, string password)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
