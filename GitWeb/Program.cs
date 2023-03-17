

using GitWeb.Data.Repositories;
using GitWeb.Domain.Entities;

var userRepo = new UserRepository();
var user = new User();
user.Id = 2;
user.FirstName = "Nozimjon";
user.LastName = "Usmonaliyev";
user.Address = "Andijan";
user.Email = "Usminaliyevnozimjon@gmail.com";
user.Bio = "Be active and strong";
user.Password = "password";
user.CreatedAt = DateTime.Now;
var res =  await userRepo.UpdateAsync(user);
Console.WriteLine(res.FirstName);





