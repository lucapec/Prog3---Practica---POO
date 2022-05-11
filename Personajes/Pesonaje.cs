using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    /*Personaje
Crear una clase abstracta llamada Personaje, que tenga las siguientes propiedades:
Nombre
Fuerza
Agilidad
Magia
y los Métodos:
CalcularDanio()
Atacar()
El método abstracto CalcularDanio y Atacar muestra por consola: “{ nombre}
hizo
{ x}
de daño”. Donde x es el daño calculado.*/
    public abstract class Personaje : IMoverse
    {
        public string? Name { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Magic { get; set; }


        public abstract int CalcularDanio();
        public virtual void Atacar()
        {
            Console.WriteLine($"{Name} hizo {CalcularDanio()} de daño");
        }
        public abstract int MoverseEjeX();
        public abstract int MoverseEjeY();
    }
}
