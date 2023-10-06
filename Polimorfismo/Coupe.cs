using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Coupe : Auto
    {
        public Coupe(byte pasajeros, Velocidades velocidad, int ruedas) : base(pasajeros, velocidad, ruedas)
        {
        }
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("La coupe avanza a {0}", this._velocidadMaxima);
        }
        public override void Frenar()
        {

        }
    }
}
