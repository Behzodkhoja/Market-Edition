// See https://aka.ms/new-console-template for more information
using Market.Service.DTOs;
using Market.Service.Services;

Console.WriteLine("Hello, World!");


var user1 = new UserCreationDto()
{
    Email = "dotnettashkent@gmail.com",
    FullName = "Saidnabi Yo'ldoshxo'jayev",
    Password = "password"
};
var user2 = new UserCreationDto()
{
    Password = "password",
    Email = "nig'matxojatyev",
    FullName = "Behzod Nig'matxo'jayev Nodir o'g'li"
};

var service = new UserService();

await service.AddAsync(user1);
await service.AddAsync(user2);