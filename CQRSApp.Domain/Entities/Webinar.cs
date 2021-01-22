using CQRSApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Domain.Entities
{
    public class Webinar : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }
        public string FacebookEventUrl { get; set; }
        public string SildesUrl { get; set; }

        public string WatchFacebookLink { get; set; }
        public string WatchYoutubeLink { get; set; }

        public DateTime Date { get; set; }
        public bool AlreadyHappend { get; set; }

    }
}
