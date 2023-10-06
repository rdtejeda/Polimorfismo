using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cohete:Transporte
    {
        #region Atributos

        public string modelo;
        public int cantidadVentanas;

        #endregion        

        #region Constructor

        public Cohete(byte pasajeros, Velocidades velocidad, int cantidadVentanas, string modelo):base(pasajeros,velocidad)
        {
            this.cantidadVentanas = cantidadVentanas;
            this.modelo = modelo;
        }

        public override string TiempoUso => "Dedes mediados del siblo XX";//throw new NotImplementedException();

        #endregion

        #region Métodos
        public override void Avanzar()
        {
            //base.Avanzar();
            Console.WriteLine("El auto avanza a {0}", this._velocidadMaxima);
        }

        public override void Frenar()
        {
            Console.WriteLine("El cohete sede a la gravedad");
        }


        #endregion



        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            base.ToString();          

            sb.AppendLine("En la clase Cohete...");

            sb.Append("Cantidad de ventanas: ");
            sb.AppendLine(this.cantidadVentanas.ToString());
            sb.Append("Modelo: ");
            sb.AppendLine(this.modelo);

            return sb.ToString();
        }

  
    }
}
