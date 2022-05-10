using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    /*Crear una clase Enemigo que tenga vida y nivel.*/
    public class Enemigo : IMoverse
    {
        public int Life;
        public int Level;
        public Enemigo(int life, int level)
        {
            Life = life;
            Level = level;
        }

        public int MoverseEjeX()
        {
            return 5;
        }

        public int MoverseEjeY()
        {
            return 5;
        }
    }
}
