using System;

namespace Site.Models
{
    public class TitleOfPage
    {
        public Guid TitleOfPageId { get; set; } = Guid.NewGuid();
        public int PageNumber { get; set; } = 0;
        public string Title { get; set; } = "Сайт, посвященный Сергею Шевкуненко";
    }
}
