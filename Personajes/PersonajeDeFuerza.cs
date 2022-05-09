﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personajes;

namespace Personajes
{
    /*Crear una clase llamada PersonajeDeFuerza, que implemente a Personaje.
   Crear un constructor para PersonajeDeFuerza que reciba los tres atributos de parámetro y se los asigne a Nombre Agilidad y Magia respectivamente.
   Fuerza estará por defecto en 100. CalcularDanio que calcula el daño en base a una fórmula que involucra las 3 propiedades (queda a imaginación de ustedes)*/
    internal class PersonajeDeFuerza : Personaje
    {
       
        public PersonajeDeFuerza(string name, int agility, int magic)
        {
            Name = name;
            Strength = 100;
            Agility = agility;
            Magic = magic;
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Agility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Magic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int CalcularDanio()
        {
            return ((Strength + Agility + Magic) * 4);
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
