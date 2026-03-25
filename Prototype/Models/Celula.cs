
using PrototypeCorpoHumano.Interfaces;

namespace PrototypeCorpoHumano.Models
{
    public class Celula : ICelulaPrototype
    {
        public string Tipo { get; set; }

        public string Funcao { get; set; }

        public int Energia { get; set; }

        public ICelulaPrototype Clone()
        {
            return (ICelulaPrototype)this.MemberwiseClone();
        }
    }
}