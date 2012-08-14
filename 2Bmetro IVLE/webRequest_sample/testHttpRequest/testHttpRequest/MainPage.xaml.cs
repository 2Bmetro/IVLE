using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO;

namespace testHttpRequest
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string test;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            GetFeed();
        }

        public void GetFeed()
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(" https://ivle.nus.edu.sg/api/Lapi.svc/Modules?APIKey=lAY3TAAcAGYcokEEqKNCt&AuthToken=BFD7CEBDEB2FC5D033A0C4C5DC5B8102A07735E53F14944FFAA3C9B05C6B35788F336E612D3A7471A890FB3E762BF4C4ABD957F8DC18C09921B2851350AC5A159B53A6417A3929407FFF745A93F238086DED62DC835F7BE16C17B68395E50A100BFD8A846189E4DD67B3E4B8B4F0EEB0621341D79613205FCF38CD1AD054EE479CB524E5F07D7673EDA3566853F6A74464344E19AF386393B1519598A1D23AB61CAC30AC3DC1688EC69EF9E56242060A0417E9A1485CB13E172C495BA980F0C23D571FE805748344F821644E493565B0&Duration=0&IncludeAllInfo=true");
            request.BeginGetResponse(new AsyncCallback(HandleResponse), request);
        }

        public void  HandleResponse(IAsyncResult result)
        {
            HttpWebRequest request = result.AsyncState as HttpWebRequest;

            if (request != null)
            {
                using (WebResponse response = request.EndGetResponse(result))
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        string feed = reader.ReadToEnd();
                        // do something with the feed here

                        test = feed;
                    }
                }
            }
        }

        private void play(object sender, RoutedEventArgs e)
        {
            testButton.Content = test;
        }
    }
}