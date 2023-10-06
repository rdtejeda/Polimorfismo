using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //clase no instanciable y marco contextuial de la gerarquia de clase
    public abstract class Transporte
    {
        #region Atributos

        protected byte _cantidadPasajeros;
        protected Velocidades _velocidadMaxima;

        #endregion
        //propiuedades mismo concepto VIRTUAL ABSTARACT
        public abstract string TiempoUso 
        { 
            get; 
        }
        #region Constructor

        public Transporte(byte pasajeros, Velocidades velocidadMaxima)
        {
            this._cantidadPasajeros = pasajeros;
            this._velocidadMaxima = velocidadMaxima;
        }

        #endregion

        #region Métodos 
        public virtual void Avanzar()
            //virtual para poder polimorfearlo lo puedo modificar overaidea
            //No obligo a implentar lo haces como yo te digo
        {
            Console.WriteLine("Estoy avanzando");
        }
        //metodo abstrarcto no tiene implemnentacio
        //Metodo abstrarcto esta si os i dento de un clase abstarcta
        //deve estar sobresctrio o definiodo derivada
        //lo OPBLIGO A IMPLEMENTAR
        public abstract void Frenar();

        #endregion

        #region Polimorfismo ToString
        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            base.ToString();
            sb.AppendLine("En la clase Transporte...");
            sb.Append("Cantidad de pasajeros: ");
            sb.AppendLine(this._cantidadPasajeros.ToString());
            sb.Append("Velocidad Máxima: ");
            sb.AppendLine(((Int32)this._velocidadMaxima).ToString());

            return sb.ToString();
        }


        //SOBRESCRIBO EL MÉTODO TOSTRING(), 
        //HEREDADO DE OBJECT
        //public string Mostrar()
        //{
        //    System.Text.StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("En la clase Transporte...");
        //    sb.Append("Cantidad de pasajeros: ");
        //    sb.AppendLine(this._cantidadPasajeros.ToString());
        //    sb.Append("Velocidad Máxima: ");
        //    sb.AppendLine(((Int32)this._velocidadMaxima).ToString());

        //    return sb.ToString();
        //}

        #endregion
    }
}
