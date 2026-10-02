using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Domain.Entities
{
    public class Notification
    {
        public int NotificationID { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsRead { get; set; }
    }
}