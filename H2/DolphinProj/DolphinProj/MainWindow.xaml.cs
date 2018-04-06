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

namespace DolphinProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegNewMember reg = new RegNewMember();
            this.Close();
            reg.Show();
        }

        private void Button_EditMember_Click(object sender, RoutedEventArgs e)
        {
            // Opens new window where a member can be shown or edited
            EditMember ed = new EditMember();
            this.Close();
            ed.Show();
        }
    }
}
