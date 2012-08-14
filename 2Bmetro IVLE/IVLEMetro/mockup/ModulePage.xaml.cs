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
    public partial class ModulePage : PhoneApplicationPage
    {
        private int moduleIndex;
        private String moduleCode;
        private String moduleName;


        public ModulePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string index = "";

            if (NavigationContext.QueryString.TryGetValue("moduleIndex", out index))
            {
                moduleIndex = Convert.ToInt32(index);
            }

            // initiate local variables with global variables
            moduleCode = (Application.Current as App).modules[moduleIndex].moduleNo;
            moduleName = (Application.Current as App).modules[moduleIndex].moduleName;

            // change the context to fit the selected module
            ModuleCodeTitle.Text = moduleName;
            ModuleCode.Text = moduleCode;
            ModuleTitle.Text = moduleName;

            // start downloading information about the designated module in async task

            // display loading page
        }
    }
}