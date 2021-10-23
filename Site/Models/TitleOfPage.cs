using System;

namespace Site.Models
{
    public class TitleOfPage
    {
        public Guid TitleOfPageId { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "Сайт, посвященный Сергею Шевкуненко";
        public uint NumberOfPage { get; set; } = 0;
    }
}
