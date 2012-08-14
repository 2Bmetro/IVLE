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

namespace mockup
{
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        public PanoramaPage1()
        {
            InitializeComponent();

            // initialize information on the list
            (Application.Current as App).modules = new List<Module>();
            (Application.Current as App).classes = new List<Class>();
            (Application.Current as App).todos = new List<Todo>();

            (Application.Current as App).modules.Add(new Module("CS2103", "3204", "software enginnering", new Announcement("assignment", "latest assignment has been uploaded!", DateTime.Today)));
            (Application.Current as App).modules.Add(new Module("MA1506", "3204", "math", new Announcement("assignment", "latest assignment has been uploaded!", DateTime.Today)));
            (Application.Current as App).modules.Add(new Module("CS2103", "test", "software enginnering", new Announcement("assignment", "latest assignment has been uploaded!", DateTime.Today)));

            (Application.Current as App).classes.Add(new Class((Application.Current as App).modules[0], DateTime.Now, 90, DateTime.Now.AddMinutes(90), "LT7A"));
            (Application.Current as App).classes.Add(new Class((Application.Current as App).modules[1], DateTime.Now, 90, DateTime.Now.AddMinutes(90), "LT7A"));
            (Application.Current as App).classes.Add(new Class((Application.Current as App).modules[2], DateTime.Now, 90, DateTime.Now.AddMinutes(90), "LT7A"));

            (Application.Current as App).todos.Add(new Todo("finish my assignment", (Application.Current as App).modules[1].latestAnnouncement, "12/06/2012"));
            (Application.Current as App).todos.Add(new Todo("finish my assignment", (Application.Current as App).modules[1].latestAnnouncement, "12/06/2012"));
            (Application.Current as App).todos.Add(new Todo("finish my assignment", (Application.Current as App).modules[1].latestAnnouncement, "12/06/2012"));

            ModuleInfo.ItemsSource = (Application.Current as App).modules;
            ClassInfo.ItemsSource = (Application.Current as App).classes;
            TodoInfo.ItemsSource = (Application.Current as App).todos;
        }

        private void viewModule(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (ModuleInfo.SelectedIndex != -1)
            {
                //MessageBox.Show("Selected index is: " + ModuleInfo.SelectedIndex);

                int moduleIndex = ModuleInfo.SelectedIndex;

                NavigationService.Navigate(new Uri(("/ModulePage.xaml?moduleIndex=" + moduleIndex), UriKind.Relative));
            }
        }

        private void viewTodo(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (TodoInfo.SelectedIndex != -1)
            {
                int todoIndex = TodoInfo.SelectedIndex;

                NavigationService.Navigate(new Uri(("/TodoPage.xaml?todoIndex=" + todoIndex), UriKind.Relative));
            }
        }
    }
}