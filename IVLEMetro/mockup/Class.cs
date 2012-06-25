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
    public class Class
    {
        public Module module { get; set; }
        public DateTime startTime { get; set; }
        public int duration { get; set; }
        public DateTime endTime { get; set; }
        public String location { get; set; }
        public int heightOfItem { get; set; }

        public Class(Module m, DateTime st, int d, DateTime et, String l)
        {
            module = m;
            startTime = st;
            duration = d;
            endTime = et;
            location = l;
            heightOfItem = 4 * d;
        }
    }
}
