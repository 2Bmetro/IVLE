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
    public class Module
    {
        public String moduleName { get; set;}
        public String moduleNo { get; set; }
        public String moduleDescrip { get; set; }
        public Announcement latestAnnouncement { get; set; }

        public Module(String name, String number, String descrip, Announcement announce)
        {
            moduleName = name;
            moduleNo = number;
            moduleDescrip = descrip;
            latestAnnouncement = announce;
        }

    }
}
