﻿using System;
using System.Web.Services.Configuration;

namespace WebApiTest.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }

        public Gig Gig { get; set; }
        public int GigId { get; set; }
    }
}