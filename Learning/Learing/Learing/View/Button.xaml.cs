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
    /// Interaction logic for Button.xaml
    /// </summary>
    public partial class Button : Window
    {
        public Button()
        {
            InitializeComponent();

            //Button btnNew = new Button();

            //btnNew.Content = "OK";

            //grdButton.Children.Add(btnNew);

            //string text = "Dev Panda";

            //TextBlock textBlock = new TextBlock();  
            //textBlock.Text = text;

            //btnNew.Content = textBlock;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button được Click rồi nè");
        }
    }
}
