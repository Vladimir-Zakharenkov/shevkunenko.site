using System;
using System.Collections.Generic;
using System.Linq;

namespace Site.Models
{
    public class FakeTitleOfPageRepository : ITitleOfPageRepository
    {
        public IQueryable<TitleOfPage> TitleOfPages => new List<TitleOfPage>()
        {
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
        }.AsQueryable<TitleOfPage>();
    }
}
