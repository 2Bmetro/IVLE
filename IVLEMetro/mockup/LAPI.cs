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
//----------------------------
using System.IO.StreamReader;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace mockup
{
    public class LAPI
    {
        public String key { get; set; }
        public String domain { get; set; }
        public User user { get; set; }


        // initialize the LAPI class and predefine the key and domain
        public LAPI(User newUser)
        {
            key = "lAY3TAAcAGYcokEEqKNCt";
            domain = "https://ivle.nus.edu.sg/";
            user = newUser;
        }

        // get the request url with API item and parameters
        public string requestURL(string item, string[] parameters, string[] paramsVal)
        {
            string url = domain + "api/Lapi.svc/" + item + "?APIKey=" + key + user.getUserToken();

            if (parameters.Length > 0)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    url += "&" + parameters[i] + "=" + paramsVal[i];
                }
            }
            return url + "&output=json";

        }

        // return the url for token achieve
        public string getTokenUrl()
        {
            return domain + "api/login/?apikey=" + key;
        }

        // pass the url and get the feed
        public void GetFeed(string url)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.BeginGetResponse(new AsyncCallback(HandleResponse), request);
        }

        // hadle the response and get the json string
        public void HandleResponse(IAsyncResult result)
        {
            HttpWebRequest request = result.AsyncState as HttpWebRequest;

            if (request != null)
            {
                using (WebResponse response = request.EndGetResponse(result))
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string feed = reader.ReadToEnd();
                        toJObject(feed);
                    }
                }
            }
        }

        // change the json string to json object
        public void toJObject(string feed, JObject JO)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (JsonWriter writer = new JsonTextWriter(feed))
            {
                serializer.Serialize(writer, JO);
            }
        }



    };
}
