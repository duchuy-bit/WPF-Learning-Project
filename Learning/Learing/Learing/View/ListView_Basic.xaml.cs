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
    /// Interaction logic for ListView_Basic.xaml
    /// </summary>
    public partial class ListView_Basic : Window
    {
        List<string> data;
        public ListView_Basic()
        {
            InitializeComponent();
            data = new List<string>() { "HowKteam.com", "Free education", "Share tobe better", "K9" };
            lsvList.ItemsSource = data;
        }
    }
}
