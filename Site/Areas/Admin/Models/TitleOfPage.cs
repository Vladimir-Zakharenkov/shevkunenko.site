using System;

namespace Site.Areas.Admin.Models
{
    public class TitleOfPage
    {
        public Guid TitleOfPageId { get; set; } = Guid.NewGuid();
        public int PageNumber { get; set; } = 0;
        public string Title { get; set; } = "Сайт, посвященный Сергею Шевкуненко";
        public string Description { get; set; } = "Сайт, посвященный Сергею Шевкуненко";
    }
}
