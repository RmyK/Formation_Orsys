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

namespace EcoleWPF
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void OuvrirEleve(object sender, EventArgs e)
        {
            var eleveWindow = new CreateEleve();
            eleveWindow.Show();
        }

        private void OuvrirProfesseur(object sender, EventArgs e)
        {
            var profWindow = new CreateProfesseur();
            profWindow.Show();
        }
    }
}
