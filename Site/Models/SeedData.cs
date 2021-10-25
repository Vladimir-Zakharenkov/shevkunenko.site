using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System;

namespace Site.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            TitleOfPageDbContext context = app.ApplicationServices.GetRequiredService<TitleOfPageDbContext>();

            if (!context.TitleOfPages.Any())
            {
                context.TitleOfPages.AddRange(

                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        NumberOfPage = 1,
                        Title = "Сайт, посвященный Сергею Шевкуненко"

                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        NumberOfPage = 2,
                        Title = "Сергей Шевкуненко - фильмы, книги, статьи, фото"
                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        NumberOfPage = 3,
                        Title = "Шевкуненко Сергей Юрьевич - биография"
                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        NumberOfPage = 4,
                        Title = "Фильм «Криминальная звезда» смотреть online"
                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        NumberOfPage = 5,
                        Title = "Фильмы с участием Сергея Шевкуненко - смотреть online"
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
