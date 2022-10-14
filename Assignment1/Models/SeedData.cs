using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment1.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Assignment1Context(serviceProvider.GetRequiredService<DbContextOptions<Assignment1Context>>()))
            {
                // OCT 14 7:00 Check if there are products in the database
                //If there are, DB is seeded and no need to inject new ones
                if (context.Product.Any())
                {
                    return;
                }
                //Adding the seed data into the database if there are no values existing
                context.Product.AddRange(
                        new Product
                        {
                            Title = "Cutting Board",
                            WoodType = "Walnut, Ash, Maple, Oak",
                            Height = 2,
                            Width = 8,
                            Length = 12,
                            Price = 19.99M,
                            Review = 5
                        },
                        new Product
                        {
                            Title = "Coaster",
                            WoodType = "Walnut, Maple",
                            Height = 1,
                            Width = 5,
                            Length = 5,
                            Price = 6.99M,
                            Review = 4
                        },
                        new Product
                        {
                            Title = "Outdoor Chair",
                            WoodType = "Oak, Ash",
                            Height = 50,
                            Width = 50,
                            Length = 50,
                            Price = 69.99M,
                            Review = 4
                        },
                        new Product
                        {
                            Title = "Cabinets",
                            WoodType = "MDF, Oak, Maple, Composite",
                            Height = 0,
                            Width = 0,
                            Length = 0,
                            Price = 0,
                            Review = 5
                        },
                        new Product
                        {
                            Title = "Desk",
                            WoodType = "Walnut, Oak",
                            Height = 60,
                            Width = 20,
                            Length = 80,
                            Price = 99.99M,
                            Review = 5
                        },
                        new Product
                        {
                            Title = "Shelves",
                            WoodType = "Walnut, Maple, Ash, MDF",
                            Height = 0,
                            Width = 2,
                            Length = 20,
                            Price = 39.99M,
                            Review = 4
                        },
                        new Product
                        {
                            Title = "Night Stand",
                            WoodType = "Walnut, Ash, Maple, Oak",
                            Height = 40,
                            Width = 20,
                            Length = 15,
                            Price = 79.99M,
                            Review = 5
                        },
                        new Product
                        {
                            Title = "Dresser",
                            WoodType = "MDF, Walnut, Oak",
                            Height = 80,
                            Width = 40,
                            Length = 20,
                            Price = 124.99M,
                            Review = 4
                        },
                        new Product
                        {
                            Title = "Dinner Table",
                            WoodType = "Walnut, Oak, Ash, Maple, Cherry",
                            Height = 30,
                            Width = 30,
                            Length = 60,
                            Price = 149.99M,
                            Review = 5
                        },
                        new Product
                        {
                            Title = "Coffee Table",
                            WoodType = "Cherry, Walnut, Ash",
                            Height = 20,
                            Width = 20,
                            Length = 40,
                            Price = 89.99M,
                            Review = 5
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
