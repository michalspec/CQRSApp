﻿using CQRSApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Functions.Posts
{
    public class PostDetailViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public CategoryDto Category { get; set; }

        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public int Rate { get; set; }
    }
}
