
using System.Collections.ObjectModel;
using PrototypeCorpoHumano.Models;

namespace PrototypeCorpoHumano.ViewModels
{
    public class CelulaViewModel
    {
        public ObservableCollection<Celula> Celulas { get; set; }

        public CelulaViewModel()
        {
            Celulas = new ObservableCollection<Celula>();

            Celulas.Add(new Celula
            {
                Tipo = "Célula Muscular",
                Funcao = "Movimento do corpo",
                Energia = 100
            });
        }

        public void ClonarCelula()
        {
            Celula celulaBase = Celulas[0];

            Celula novaCelula = (Celula)celulaBase.Clone();

            Celulas.Add(novaCelula);
        }
    }
}