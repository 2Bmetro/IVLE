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
    public static class URLGenerator
    {
        public const string APIKey = "lAY3TAAcAGYcokEEqKNCt";
        public const string APIUrl = "https://ivle.nus.edu.sg/api/lapi.svc";
        public static string token = "";

        public static string LoginURL
        {
            get
            {
                return "https://ivle.nus.edu.sg/api/login/?apikey=" + APIKey;
            }
        }
    }
}
