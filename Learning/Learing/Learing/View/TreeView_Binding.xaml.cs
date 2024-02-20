using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for TreeView_Binding.xaml
    /// </summary>
    public partial class TreeView_Binding : Window
    {
        public TreeView_Binding()
        {
            InitializeComponent();//MenuItem root = new MenuItem() { Title = "Menu" };
            //MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            //childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
            //childItem1.Items.Add(new MenuItem() { Title = "Child item #1.2" });
            //root.Items.Add(childItem1);
            //root.Items.Add(new MenuItem() { Title = "Child item #2" });
            //trvMenu.Items.Add(root);

            List<Family> families = new List<Family>();

            Family family1 = new Family() { Name = "HowKteam.com" };
            family1.Members.Add(new FamilyMember() { Name = "HowKteam", Age = 42 });
            family1.Members.Add(new FamilyMember() { Name = "Kteam", Age = 39 });
            family1.Members.Add(new FamilyMember() { Name = "Free Education", Age = 13 });
            families.Add(family1);

            Family family2 = new Family() { Name = "Kteam" };
            family2.Members.Add(new FamilyMember() { Name = "K9", Age = 31 });
            family2.Members.Add(new FamilyMember() { Name = "Mushi", Age = 28 });
            families.Add(family2);

            trvFamilies.ItemsSource = families;
        }
    }

    public class MenuItem
    {
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();
        }

        public string Title { get; set; }

        public ObservableCollection<MenuItem> Items { get; set; }
    }

    public class Family
    {
        public Family()
        {
            this.Members = new ObservableCollection<FamilyMember>();
        }

        public string Name { get; set; }

        public ObservableCollection<FamilyMember> Members { get; set; }
    }

    public class FamilyMember
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
