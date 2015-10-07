using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComuniItaliani.AmadeiNicola
{
    class Comune
    {
        string _nome;
        double _popolazione;
        int _codRegione;
        
        public Comune(string rigaFile)
        {
            string[] container = rigaFile.Split(';');
            _nome = container[12];
            _popolazione = Convert.ToDouble(container[21]);
            _codRegione = Convert.ToInt32(container[3]);
            
        }

        public string Visualizzati()
        {
            return _nome.PadRight(30) + _popolazione.ToString().PadRight(8) + _codRegione.ToString().PadRight(6);
        }
        public string Nome { get { return _nome; } }
        public double Popolazione { get { return _popolazione; } }
        public int CodiceRegione { get { return _codRegione; } }

    }
}
