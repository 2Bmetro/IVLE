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

namespace IVLE
{
    public class IAPI
    {
        // attributes
        public User user;
        public string domain { get; set; }
        public string key { get; set; }
        public const string DOMAIN = "https://ivle.nus.edu.sg/";
        public const string KEY = "geTZ5OAh2OjOxjqELVJEf";

        // constructor
        public IAPI()
        {
            domain = DOMAIN;
            key = KEY;
            user = new User();
        }

        public string requestURL(string item, Array parameters)
        {
            string url = domain + "api/lapi.svc/" + item + "?APIKey=" + key + "&AuthToken=" + user.getToken();

            if (parameters.Length > 0)
            {
                foreach (string i in parameters)
                {
                    url = "&" + i + "=" + parameters[i];      // e.g parameter{courseID="1111"}
                }
            }
            return url + "&output=json";
        }

        public string loginURL(string item)
        {
            if (item)
            {
                return domain + "api/lapi.svc/" + item + "?output=json" +
                    "&APIKey=" + key + "&Token=" + user.token;
            }
            else
            {
//                 return this.domain + "api/login/?apikey=" + this.key +
//                         "&url=" + encodeURIComponent("http://www.nus.edu.sg");
            }
        }

        // get the response from the requestURL
        public void getResponse() { }

        public void download() { }

        // mark an announcement as read
        public void markAnnRead() { }


    }

    
}
