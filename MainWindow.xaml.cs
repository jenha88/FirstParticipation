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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstParticipation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LBOut.Content = "";
            LBOut.Visibility = Visibility.Hidden; //Makes the label disappear 
        }

       
        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            string DOBValue = TXTBD.Text;
            DateTime dob = Convert.ToDateTime(DOBValue);
            TimeSpan age = DateTime.Now - dob;
            string Name1 = Name.Text;
            int years = age.Days / 365;

            LBOut.Content = $"Hello there {Name1}! You're {years.ToString("G0")}"; //outputing what the users see 
            LBOut.Visibility = Visibility.Visible;
        }

      
    }
}
