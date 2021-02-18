using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimmysApp
{
    class ComicQuery
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public ComicQuery(string title, string subtitle, string description, string imagePath)
        {
            Title = title;
            Subtitle = subtitle;
            Description = description;
            ImagePath = imagePath;
        }
    }
}
