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
    public class User
    {
        // attributes
        public string token { get; set; }
        public bool validated { get; set; }
        public Todo todoList;

        // constructor
        public User()
        {
            token = null;
            validated = false;
            todoList = new Todo();
        }

        public string getToken()
        {
            return token;
        }

        public void setToken() { }

        public void saveToken() { }

        public void clearUser() { }
    }
}
