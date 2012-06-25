using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace mockup
{
    public class Todo
    {
        public String details { get; set; }
        public Announcement relatedAnnounce { get; set; }
        public String deadline { get; set; }

        public Todo(String myDetails, Announcement myAnnounce, String myDeadline)
        {
            details = myDetails;
            relatedAnnounce = myAnnounce;
            deadline = myDeadline;
        }
    }
}
