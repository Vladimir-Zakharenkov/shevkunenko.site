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
                        PageNumber = 1,
                        Title = "Сайт, посвященный Сергею Шевкуненко",
                        Description = "Эта история по-своему уникальна и практически не имеет аналогов в истории российского кинематографа. Подававший большие надежды актер волею судьбы угодил в тюрьму и довольно быстро добился славы и признания совсем в другой среде - уголовной. Последней ступенькой, на которую сумел забраться в преступной иерархии этот бывший актер, была должность «положенца», которая предшествует самому высокому титулу в уголовной среде - вора в законе. Имя этого человека - Сергей Шевкуненко."

                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        PageNumber = 2,
                        Title = "Сергей Шевкуненко - фильмы, книги, статьи, фото",
                        Description = "Навигация по основным разделам сайта, посвященного Сергею Шевкуненко. Биография. Статьи в прессе и упоминания в книгах. Ссылки в интернете. Информация по фильмам Кортик, Бронзовая птица, Пропавшая экспедиция, Криминальная звезда. Фильмы и телепрограммы о Сергее Шевкуненко. Гостевая книга сайта. Писатель Анатолий Наумович Рыбаков."
                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        PageNumber = 3,
                        Title = "Шевкуненко Сергей Юрьевич - биография",
                        Description = "Биография актера Шевкуненко Сергея Юрьевича"
                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        PageNumber = 4,
                        Title = "Фильм «Криминальная звезда» смотреть online",
                        Description = "фильм «Криминальная звезда» о Сергее Шевкуненко. Его имя ни о чём не говорит сегодняшним подросткам, а среди советских мальчишек его герой был кумиром – отважный парень, проводящий расследование и поимки преступников в легендарной &laquo;Бронзовой птице&raquo; и &laquo;Кортике&raquo;. Но кроме этой пары фильмов о нем не известно ничего, ведь цензура не допускала &laquo;порочащие&raquo; факты. А тем временем бравый &laquo;борец за честность&raquo; из фильмов оказался настоящим преступником, которому оставалась малость до &laquo;вора в законе&raquo;."
                    },
                    new TitleOfPage
                    {
                        TitleOfPageId = Guid.NewGuid(),
                        PageNumber = 5,
                        Title = "Фильмы с участием Сергея Шевкуненко - смотреть online",
                        Description = "Фильмы с участием Сергея Шевкуненко"
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
