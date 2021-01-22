﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Functions.Posts
{
    public class PostInListViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public int Rate { get; set; }
    }
}
