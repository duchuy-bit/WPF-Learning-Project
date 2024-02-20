using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ListView_Sort.xaml
    /// </summary>
    public partial class ListView_Sort : Window
    {
        protected class User
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

        public bool IsSort;
        public ListView_Sort()
        {
            InitializeComponent();

            IsSort = false;
            List<User> items = new List<User>();
            items.Add(new User() { Name = "HowKteam.com", Age = 42 });
            items.Add(new User() { Name = "Kteam", Age = 13 });
            items.Add(new User() { Name = "Free Education", Age = 39 });
            items.Add(new User() { Name = "Share to be better", Age = 13 });
            lvUsers.ItemsSource = items;

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            //view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = sender as GridViewColumnHeader;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            if (IsSort)
            {
                //view.SortDescriptions.Remove(new SortDescription(header.Content.ToString(), ListSortDirection.Descending));
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new SortDescription(header.Content.ToString(), ListSortDirection.Ascending));
            }
            else
            {
                //view.SortDescriptions.Remove(new SortDescription(header.Content.ToString(), ListSortDirection.Ascending));
                view.SortDescriptions.Clear();
                view.SortDescriptions.Add(new System.ComponentModel.SortDescription(header.Content.ToString(), ListSortDirection.Descending));
            }

            IsSort = !IsSort;
        }
    }

    
}
