using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Auto:Transporte
    {
        #region Atributos

        public int cantidadRuedas;

        #endregion

        #region Propiedades

        #endregion

        #region Constructor

        public Auto(byte pasajeros, Velocidades velocidad, int ruedas):base(pasajeros,velocidad)
        {
            this.cantidadRuedas = ruedas;
        }

        #endregion


        public override string TiempoUso// => throw new NotImplementedException();
        {
            get
            {
                return "Se usa desde 1886";
            }
        }

        #region Métodos
        public override void Avanzar()//lo debo overraider
            //no ees el mismo metodo que en la base
            //para que haya polimorfismno debemo definir el metodo
            //de la clase base virtrual
            //para poder sobreescribirlo
            //lo puedo redefinir totalmentye o llamar la base y agregar
        {
            base.Avanzar(); //llamo a la base llamada explicita
            Console.WriteLine("El auto avanza a {0}", this._velocidadMaxima);
        }
        //sobreesdcrobo el abstrato de la basek
        public override void Frenar()
        {
            //base.Frenar(); NO FUNCIONA PPRQUE ES ABSTRACTO
            //no me condiciona la base O
            Console.WriteLine("reduzco velocidad pisando el freno...");
        }

        #endregion
        public override string ToString()
        {
            return base.ToString();
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.ToString());

            sb.AppendLine("En la clase Auto...");
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantidadRuedas.ToString());

            return sb.ToString();
        }
        public void TocarBocina()
        {
            Console.WriteLine("Tututu");
        }
        //public string mostrar()
        //{
        //    System.Text.StringBuilder sb = new StringBuilder();

        //    //INVOCO AL TOSTRING() DE LA CLASE BASE
        //    sb.AppendLine(base.Mostrar());

        //    sb.AppendLine("En la clase Auto...");
        //    sb.Append("Cantidad de ruedas: ");
        //    sb.AppendLine(this.cantidadRuedas.ToString());

        //    return sb.ToString();
        //} 
    }
}

