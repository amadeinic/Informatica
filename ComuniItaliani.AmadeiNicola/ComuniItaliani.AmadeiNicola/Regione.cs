using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComuniItaliani.AmadeiNicola
{
    class Regione
    {
        int _codRegione;
        string _nome;

        public Regione(string rigaFile)
        {
            string[] container = rigaFile.Split(';');
            _codRegione = Convert.ToInt32(container[0]);
            _nome = container[1];                     
        }

        public int CodiceRegione { get { return _codRegione; } }
        public string Nome { get { return _nome; } }
        
    }
}
