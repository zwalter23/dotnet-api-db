using dotnet_core_with_api_and_database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_with_api_and_database.Data
{
    public static class DbInitializer
    {

        public static void Initialize(ItemContext context)
        {
            context.Database.EnsureCreated();

            // Look for any items
            if (context.Items.Any())
            {
                return;   // DB has been seeded
            }

            var items = new Item[]
            {
            new Item{Name="teszt1"},
            new Item{Name="teszt12"},
            new Item{Name="teszt13"},
            new Item{Name="teszt14"}
            };
            foreach (Item s in items)
            {
                context.Items.Add(s);
            }
            context.SaveChanges();

        }
}
}
