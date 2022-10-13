using EcoleBusiness.DataModels;
using EcoleBusiness.Services;

namespace EcoleWinForm
{
    public partial class EcoleForm : Form
    {
        public EcoleForm()
        {
            InitializeComponent();
        }

        private void EcoleForm_Load(object sender, EventArgs e)
        {
            var ecoleService = new EcoleService(1);
            ListeEleve.DataSource = ecoleService.GetEleves();
        }

        private void ShowEleveDetail(object sender, EventArgs e)
        {
            Eleve eleve = (Eleve)((ListBox)sender).SelectedItem;
            //MessageBox.Show(eleve.Afficher());
            textBox1.Text = eleve.Nom;
            textBox2.Text = eleve.Prenom;
            textBox3.Text = eleve.Moyenne.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ecoleService = new EcoleService(1);
            //ecoleService.Inscrire(new Eleve() { Nom = textBox1.Text });
        }
    }
}