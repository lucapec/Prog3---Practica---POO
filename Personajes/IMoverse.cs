using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    /*Crear una interfaz IMoverse que tenga 2 métodos: MoverseEjeX y MoverseEjeY. Todos los personajes y enemigos deben implementar esta interfaz.*/
    internal interface IMoverse
    {
        int MoverseEjeX();
        int MoverseEjeY();
    }
}
