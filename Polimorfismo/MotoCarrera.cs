using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class MotoCarrera : Transporte
    {
        public MotoCarrera(byte pasajeros, Velocidades velocidadMaxima) : base(pasajeros, velocidadMaxima)
        {
        }

        public override string TiempoUso => throw new NotImplementedException();

        //metodo abstraco obligadoa impleenta
        public override void Frenar()
        {
            throw new NotImplementedException();
        }
        //metodo virtual no opbligado y toma compartmiento bas
    }
}
