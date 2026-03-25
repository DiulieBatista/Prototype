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

using System.Windows;
using PrototypeCorpoHumano.ViewModels;

namespace PrototypeCorpoHumano
{
    public partial class MainWindow : Window
    {
        CelulaViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new CelulaViewModel();

            AtualizarLista();
        }

        private void Clonar_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClonarCelula();

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            ListaCelulas.Items.Clear();

            foreach (var celula in viewModel.Celulas)
            {
                ListaCelulas.Items.Add(
                    $"{celula.Tipo} - Energia {celula.Energia}"
                );
            }
        }
    }
}