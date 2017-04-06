using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013223347_GROMERO
{
    class cinturon
    {
        

        public int Metraje { get; set; }
        public string NumSerie { get; set; }


        public cinturon()
        {
        }

        public cinturon(string _NumSerie, int _Metraje)
        {
            Metraje = _Metraje;
            NumSerie = _NumSerie;
        }

    }
}
