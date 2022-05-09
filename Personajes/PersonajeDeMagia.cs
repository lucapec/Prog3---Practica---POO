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
    internal class PersonajeDeMagia : Personaje
    {
        protected int damage_;

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Agility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Magic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PersonajeDeMagia1(string name, int strength, int agility, int magic)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = magic;
        }

        public PersonajeDeMagia2(string name, int strength, int agility)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = 60;
        }

        public override int CalcularDanio()
        {
            damage_ = (Strength + Agility + Magic) * 4;
            return damage_; 
        }

        public override string Atacar(string name, int damage)
        {
            return $"{name} hizo {damage_} de daño gracias a su magia";
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
