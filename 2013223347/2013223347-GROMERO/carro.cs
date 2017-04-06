using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013223347_GROMERO
{
    public class carro
    {
        llanta     _llanta;
        Asiento    _asiento;
        parabrisas _parabrisas;
        Volante    _volante;
        public string NumSerieMotor  { get; set; }
        public string NumSerieChasis { get; set; }

        public carro(string _numSerieMotor ,string _numSerieChasis){
            NumSerieChasis = _numSerieChasis;
            NumSerieMotor = _numSerieMotor;
            _llanta     = new llanta();
            _asiento    = new Asiento();
            _parabrisas = new parabrisas();
            _volante    = new Volante();
            

    }
        public carro()
        {

        }

    }
}
