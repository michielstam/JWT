using Catalog.Models;

namespace Catalog.Repositories
{
    public class UserRepository 
    {
       public static List<User> Users = new()
       {
           new() {Username = "michiel_admin", EmailAdress = "michiel.admin@email.com", Password = "Password123", 
           GivenName = "Michiel", Surname = "Stam", Role = "Administrator" },
           new() {Username = "michiel_standard", EmailAdress = "michiel.admin@email.com", Password = "Standard123", 
           GivenName = "Michiel", Surname = "Stam", Role = "Standard" }
       };
    }
}