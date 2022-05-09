using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    /*Crear una clase llamada PersonajeDeAgilidad que tenga un constructor que reciba los 4 atributos como parámetro.
 Al atacar debe implementar el método CalcularDanio() y utilizar la fórmula Fuerza/2*Agilidad*Magia/2 para calcular el daño.*/
    internal class PersonajeDeAgilidad : Personaje
    {
      
      
        public PersonajeDeAgilidad(string name, int strength, int agility, int magic)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = magic;
        }

      
        public override int CalcularDanio()
        {
        
            return ((Strength / 2) * ((Agility * Magic) / 2)); ;
        }

        public override string Atacar(string name, int damage)
        {

            return base.Atacar(name, CalcularDanio());
        }

        public override int MoverseEjeX()
        {
            return 9;
        }

        public override int MoverseEjeY()
        {
            return 6;
        }
    }
}
