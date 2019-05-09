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

namespace WPF_MVVM_FCAMUSO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        private Models.IPersoneService  personeService = null;

        public MainWindow(Models.IPersoneService personeService)
        {
            InitializeComponent();
            this.personeService = personeService;
            cmbPersone.ItemsSource = personeService.Persone;
            cmbPersone.DisplayMemberPath = "Cognome";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            salutaMi();
        }

        private void salutaMi()
        {
            if (cmbPersone.SelectedItem!=null)
            {
               var persona = (Models.Persona)cmbPersone.SelectedItem;

                txtSaluto.Text = $"Ciao {persona.Nome} {persona.Cognome}";

            }
        }
    }
}
