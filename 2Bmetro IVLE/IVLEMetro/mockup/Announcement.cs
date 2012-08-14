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
    public class Announcement
    {
        public String announceName { get; set; }
        public String announceContent { get; set; }
        public DateTime announceTime { get; set; }

        public Announcement(String name, String content, DateTime time)
        {
            announceName = name;
            announceContent = content;
            announceTime = time;
        }
    }
}
