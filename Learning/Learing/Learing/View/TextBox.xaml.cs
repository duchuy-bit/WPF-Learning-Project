using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for TextBlock.xaml
    /// </summary>
    public partial class TextBlock : Window
    {
        public TextBlock()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tblValue.Text = txbValue.Text;
        }

        int _nhanDoiNiemVui (int value)
        {
            return value * 2;
        }

        private void changeText(object sender, TextChangedEventArgs e)
        {
            int value = 0;
            if (int.TryParse(txbValue.Text, out value))
            {
                tblValue.Text = _nhanDoiNiemVui(value).ToString();
            }
        }
    }
}
