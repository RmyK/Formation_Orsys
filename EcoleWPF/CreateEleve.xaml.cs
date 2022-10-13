using EcoleBusiness.DataModels;
using EcoleBusiness.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for CreateEleve.xaml
    /// </summary>
    public partial class CreateEleve : Window, INotifyPropertyChanged
    {
        private Eleve selectedEleve;
        public Eleve SelectedEleve
        {
            get => selectedEleve;
            set { selectedEleve = value; OnPropertyChanged(); }
        }

        private EleveService eleveService { get; set; }
        public ObservableCollection<Eleve> MesEleves { get; set; }

        public CreateEleve()
        {
            InitializeComponent();
            DataContext = this;
            eleveService = new EleveService();

            this.Loaded += LoadedEvent;
            //LoadData();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void LoadData()
        {
            MesEleves = new ObservableCollection<Eleve>(eleveService.GetEleves());
            SelectedEleve = new Eleve() { DateNaissance = DateTime.Now, EcoleId = 1 };
            OnPropertyChanged(nameof(MesEleves));
        }

        private void LoadedEvent(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SauvegardeEleve(object sender, RoutedEventArgs e)
        {
            eleveService.InsertOrUpdateEleve(SelectedEleve);
            LoadData();
        }

        private void SelectEleve(object sender, EventArgs e)
        {
            var eleve = (Eleve)((ListBox)sender).SelectedItem;
            SelectedEleve = eleve;
            //OnPropertyChanged(nameof(SelectedEleve));
        }
    }
}
