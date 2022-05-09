﻿using System;
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
    abstract class Personaje
    {
        public abstract string Name { get; set; }
        public abstract int Strength { get; set; }
        public abstract int Agility { get; set; }
        public abstract int Magic { get; set; }


        public abstract int CalcularDanio();
        public virtual string Atacar(string name, int damage)
        {
            return $"{name} hizo {damage} de daño";
        }

        
    }
}