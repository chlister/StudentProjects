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

namespace DolphinProj
{
    /// <summary>
    /// Interaction logic for RegNewMember.xaml
    /// </summary>
    public partial class RegNewMember : Window
    {
        public RegNewMember()
        {
            InitializeComponent();
        }

        private void Reg_NewMemberButton_Click(object sender, RoutedEventArgs e)
        {
            // Method initialises a new member and puts the info into the database
        }

        private void Reg_BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}
