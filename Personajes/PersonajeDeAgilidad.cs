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
        public int damage_;
        public PersonajeDeAgilidad(string name, int strength, int agility, int magic)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = magic;
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Agility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Magic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

      
        public override int CalcularDanio()
        {
            damage_ = ((Strength / 2) * ((Agility * Magic) / 2));
            return damage_;
        }

        public override string Atacar(string name, int damage)
        {

            return base.Atacar(name, damage_);
        }

        public override int MoverseEjeX()
        {
            throw new NotImplementedException();
        }

        public override int MoverseEjeY()
        {
            throw new NotImplementedException();
        }
    }
}
