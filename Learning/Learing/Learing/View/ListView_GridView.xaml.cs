using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Learing.View
{
    /// <summary>
    /// Interaction logic for ListView_GridView.xaml
    /// </summary>
    public partial class ListView_GridView : Window
    {
        public ListView_GridView()
        {
            InitializeComponent();


            List<User> items = new List<User>();
            items.Add(new User() { Name = "HowKteam.com", Age = 42, Mail = "1@kteam.com" });
            items.Add(new User() { Name = "Kteam", Age = 39, Mail = "2@kteam.com" });
            items.Add(new User() { Name = "Free Education", Age = 7, Mail = "3@kteam.com" });
            lvUsers.ItemsSource = items;
        }
    }

    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }
    }
}
