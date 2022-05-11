using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    /*Crear una clase llamada PersonajeDeMagia que tenga 2 constructores, uno que reciba los 4 atributos como parámetro y otro que reciba 3 y 
le ponga el atributo magia en 60 por defecto. Al atacar debe sobreescribir el método Atacar() para que diga: “{ nombre}
hizo
{ x}
de daño gracias a su magia” y utilizar la fórmula Fuerza+Agilidad+Magia*4 para calcular el daño.
*/
    public class PersonajeDeMagia : Personaje
    {
        

        public PersonajeDeMagia(string name, int strength, int agility, int magic)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = magic;
        }

        public PersonajeDeMagia(string name, int strength, int agility)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = 60;
        }

        public override int CalcularDanio()
        {
            return (Strength + Agility + Magic) * 4;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Name} hizo {CalcularDanio()} de daño gracias a su magia");
        }

        public override int MoverseEjeX()
        {
            return 6;
        }

        public override int MoverseEjeY()
        {
            return 2;
        }
    }
}
