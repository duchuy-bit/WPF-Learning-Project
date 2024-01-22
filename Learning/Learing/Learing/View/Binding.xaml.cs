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
    /// Interaction logic for Binding.xaml
    /// </summary>
    public partial class Binding : Window, INotifyPropertyChanged
    {
        private string buttonName;

        public Binding()
        {
            InitializeComponent();
            this.DataContext = this;    

            buttonName = "this is example about binding";
        }

        public string ButtonName { 
            get => buttonName; 
            set {
                buttonName = value;
                OnPropertyChanged("ButtonName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName)); 
            }
        }
    }
}
