namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Capacidad de redefinir metodos y propiedades de clases base
             * Dos clase derivan de una base pero la implementan haciendo distintas cosas
             * las clases derivadas implem,entan de distinta mamera los metodos y propiedades
             * dedbe haber herencia y/o interfases,             
             */
            //Coupe unaCoupe = new Coupe(2, Velocidades.Alta, 4);
            //unaCoupe.Avanzar();
            //unaCoupe.Frenar();
            //MotoCarrera unaMotoCarr = new MotoCarrera(1, Velocidades.Alta);
            //unaMotoCarr.Avanzar();

            //Auto unAuto = new Auto(4, Velocidades.Media, 4);
            //Console.WriteLine(   unAuto.ToString());

            //puerdo crear un variable de un tipo e instarciarla de una derivada
            //EL POLIMORFISMO SE DECIDE EN TIEMPOP DE EJECUCION

            Transporte miAuto = new Auto(4, Velocidades.Media, 4);
            Caballo miCaballo = new Caballo("Equinus", 2, Velocidades.Minima, Colores.Pinto);
            Cohete miCohete = new Cohete(16, Velocidades.Hiper, 5, "2000 Space");
            Caballo miOtroCaballo = new Caballo("ico", 2, Velocidades.Minima, Colores.Negro);
            Cohete miOtroCohete = new Cohete(5, Velocidades.Hiper, 3, "Odisea Space");

            List<Transporte> listaTransportes = new List<Transporte>();

            listaTransportes.Add(miAuto);
            listaTransportes.Add(miCaballo);
            listaTransportes.Add(miCohete);
            listaTransportes.Add(miOtroCohete);
            listaTransportes.Add(miOtroCaballo);

            //en tiempo de ejecucion se decide que metodo llamar
            foreach (Transporte item in listaTransportes)
            {
                //Console.WriteLine( item.ToString() );
                item.Avanzar();
                if (item.GetType() == typeof(Caballo))
                {
                    item.Frenar();
                }
                if(item is Caballo)
                {
                    item.Frenar();
                }
                if(item is Auto)
                {
                    ((Auto)item).TocarBocina();
                }
            }
            


        }
    }
}