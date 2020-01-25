using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Games2020_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Games2020_1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameContexDb(
                serviceProvider
                    .GetRequiredService<DbContextOptions<GameContexDb>>()))
            {
                if (context.Games.Any())
                {
                    return;
                }

                Genre rpg = new Genre {Name = "RPG", Description = "Gra Role.."};
                Genre fps = new Genre {Name = "FPS", Description = "gry akcji z 1 osoby"};
                Genre mmo = new Genre {Name = "MMO RPG", Description = "jakieś gry"};
                Genre rts = new Genre {Name = "RTS", Description = "Strategiczne"};
                Genre przy = new Genre {Name = "przygodowa", Description = "Gry przygodowe"};
                context.Genres.AddRange(rpg,fps,mmo,rts,przy);
                context.Games.AddRange(
                    new Game { Title = "Wiedźmin 3",Price = 34.45M,
                        YearProd = new DateTime(2009,1,21),Genre = rpg},
                    new Game
                    {Title = "Diablo 3",Price = 68.99M,YearProd = new DateTime(2012,4,23),Genre = rpg},


                    new Game
                            { Title = "Diablo 3", Price = 68.99M, YearProd = new DateTime(2012, 4, 23), Genre = rpg },

                    new Game
                        { Title = "Minecraft", Price = 98.99M, YearProd = new DateTime(2010, 4, 23), Genre = rts },
                    new Game
                        { Title = "Fifia", Price = 68.99M, YearProd = new DateTime(2012, 4, 23), Genre = fps },
                    new Game
                        { Title = "Tropico 3", Price = 68.99M, YearProd = new DateTime(2012, 4, 23), Genre = rts },
                    new Game
                        { Title = "POE", Price = 0.0M, YearProd = new DateTime(2012, 4, 23), Genre = rpg },
                    new Game
                        { Title = "Syberia", Price = 68.99M, YearProd = new DateTime(2012, 4, 23), Genre = przy },
                    new Game
                        { Title = "Syberia 2", Price = 68.99M, YearProd = new DateTime(2012, 4, 23), Genre = przy }
                    );
                context.SaveChanges();
            }   
        }
    }
}
