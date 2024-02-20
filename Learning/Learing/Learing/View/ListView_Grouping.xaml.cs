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
    /// Interaction logic for ListView_Grouping.xaml
    /// </summary>
    public partial class ListView_Grouping : Window
    {
        public ListView_Grouping()
        {
            InitializeComponent();

            List<User> items = new List<User>();
            items.Add(new User() { Name = "HowKteam.com", Age = 42, Sex = SexType.Male });
            items.Add(new User() { Name = "Kteam", Age = 39, Sex = SexType.Female });
            items.Add(new User() { Name = "Free Education", Age = 13, Sex = SexType.Male });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);
        }

        public enum SexType { Male, Female };

        public class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Mail { get; set; }

            public SexType Sex { get; set; }
        }
    }
}
