using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    /*
Crear una clase estática llamada Turno que implemente 2 métodos estáticos:
public static void Atacarse(IList<Personaje> personajes)
public static void MoverFichas(IMoverse ficha)

El primero tiene que recibir una lista de todos los personajes instanciados y hacerlos atacar.
El segundo recibe un objeto que implementa IMoverse y los hace moverse en el eje X y en el Y.*/
    public static class Turno 
    {
        public static void Atacarse(IList<Personaje> personajes)
        { 
          
            foreach (var personaje in personajes)
            {
                personaje.Atacar();
            }
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();

        }

    }
}
