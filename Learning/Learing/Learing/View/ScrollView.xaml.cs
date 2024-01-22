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
    /// Interaction logic for ScrollView.xaml
    /// </summary>
    public partial class ScrollView : Window
    {
        public ScrollView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // get scroll bar offset value
            //MessageBox.Show(scvMain.VerticalOffset.ToString());

            // get viewport height
            //MessageBox.Show(scvMain.ViewportHeight.ToString());

            // scroll to end
            //scvMain.ScrollToEnd();

            // maximum scroll offset
            //MessageBox.Show(scvMain.ScrollableHeight.ToString());           
        }
    }
}
