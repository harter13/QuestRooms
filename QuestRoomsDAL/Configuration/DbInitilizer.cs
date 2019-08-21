using QuestRoomsDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRoomsDAL.Configuration
{
    class DbInitilizer: DropCreateDatabaseAlways<RoomsContext>
    {
        protected override void Seed(RoomsContext context)
        {
            Room room = new Room();
            
            room.Name = "Today";
            room.Description = "the apartment consists of three rooms and many puzzles";
            room.PassingTime = new TimeSpan(0, 45, 0);
            room.NumberPlayers = 7;
            room.YearPlayers = 12;
            Address address = new Address();
            address.Country = new Country { Name = "Golandia" };
            address.City = new City { Name = "Varash" };
            address.Street = new Street { Name = "Polubotka" };
            address.HouseNumber = 13;
            room.Address = address;
            room.Phone = "+380965985412";
            room.Email = "gd@ukr.ner";
            Company company = new Company();
            company.Name = "Fire";
            room.Company = company;
            room.Company.Name = "Fire";
            room.Rating = 10;
            room.LevelFear = 8;
            room.LevelDifficulty = 5;
            context.rooms.Add(room);


            room.Name = "Rivera";
            room.Description = "Apartment consists of two rooms and many puzzles";
            room.PassingTime = new TimeSpan(1,35,0);
            room.NumberPlayers = 5;
            room.YearPlayers = 14;
            Address addres = new Address();
            addres.Country = new Country { Name = "Ukraine" };
            addres.City = new City { Name = "Kopanica" };
            addres.Street = new Street { Name = "Sobaki" };
            addres.HouseNumber = 9;
            room.Address = addres;
            room.Phone = "+380965925411";
            room.Email = "oriyr@ukr.net";
            Company compan = new Company();
            //compan.Name = "Halva";
            //room.Company = company;
            room.Company.Name = "sdfsd";
            room.Rating = 7;
            room.LevelFear = 10;
            room.LevelDifficulty = 7;
            context.rooms.Add(room);


            room.Name = "Pindos";
            room.Description = "One rooms and many puzzles";
            room.PassingTime = new TimeSpan(1, 0, 0);
            room.NumberPlayers = 2;
            room.YearPlayers = 30;
            Address addre = new Address();
            addre.Country = new Country { Name = "Ukraine" };
            addre.City = new City { Name = "Kopanica" };
            addre.Street = new Street { Name = "Sobaki" };
            addre.HouseNumber = 4;
            room.Address = addre;
            room.Phone = "+3805418752103";
            room.Email = "potjnka@ukr.net";
            Company compa = new Company();
            compa.Name = "Sitro";
            room.Company = compa;
            room.Rating = 10;
            room.LevelFear = 8;
            room.LevelDifficulty = 5;
            context.rooms.Add(room);


            room.Name = "Cigan";
            room.Description = "One rooms";
            room.PassingTime = new TimeSpan(1, 10, 20);
            room.NumberPlayers = 10;
            room.YearPlayers = 25;
            Address addr = new Address();
            addr.Country = new Country { Name = "Roominia" };
            addr.City = new City { Name = "Ciganovicha" };
            addr.Street = new Street { Name = "Konj" };
            addr.HouseNumber = 20;
            room.Address = addre;
            room.Phone = "+3803252123620";
            room.Email = "vkrav@roo.net";
            Company comp = new Company();
            comp.Name = "Dvir";
            room.Company = comp;
            room.Rating = 1;
            room.LevelFear = 2;
            room.LevelDifficulty = 3;
            context.rooms.Add(room);

            context.SaveChanges();

        }

    }
}
