
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
de daño”. Donde x es el daño calculado.

Crear una clase llamada PersonajeDeFuerza, que implemente a Personaje.
Crear un constructor para PersonajeDeFuerza que reciba los tres atributos de parámetro y se los asigne a Nombre Agilidad y Magia respectivamente.
Fuerza estará por defecto en 100. CalcularDanio que calcula el daño en base a una fórmula que involucra las 3 propiedades (queda a imaginación de ustedes)

Crear una clase llamada PersonajeDeAgilidad que tenga un constructor que reciba los 4 atributos como parámetro.
Al atacar debe implementar el método CalcularDanio() y utilizar la fórmula Fuerza/2*Agilidad*Magia/2 para calcular el daño.

Crear una clase llamada PersonajeDeMagia que tenga 2 constructores, uno que reciba los 4 atributos como parámetro y otro que reciba 3 y 
le ponga el atributo magia en 60 por defecto. Al atacar debe sobreescribir el método Atacar() para que diga: “{ nombre}
hizo
{ x}
de daño gracias a su magia” y utilizar la fórmula Fuerza+Agilidad+Magia*4 para calcular el daño.

Crear una clase Enemigo que tenga vida y nivel.

Crear una interfaz IMoverse que tenga 2 métodos: MoverseEjeX y MoverseEjeY. Todos los personajes y enemigos deben implementar esta interfaz.

Crear una clase estática llamada Turno que implemente 2 métodos estáticos:
public static void Atacarse(IList<Personaje> personajes)
public static void MoverFichas(IMoverse ficha)

El primero tiene que recibir una lista de todos los personajes instanciados y hacerlos atacar.
El segundo recibe un objeto que implementa IMoverse y los hace moverse en el eje X y en el Y. 
Hacer que en program reciba algunos personajes y un enemigo para probar.

*/
namespace Personajes
{
 
    public class Program
    {
        public static void Main()
        {
            List<Personaje> personajes = new List<Personaje>();
            personajes.Add(new PersonajeDeFuerza("Kratos", 45, 23));
            personajes.Add(new PersonajeDeAgilidad("Ninja", 45, 80, 23));
            personajes.Add(new PersonajeDeMagia("Mago oscuro", 45, 23));
            personajes.Add(new PersonajeDeMagia("Harry Potter", 45, 23, 80));
            personajes.Add(new PersonajeDeFuerza("Dante", 60, 40));

            Console.WriteLine("///////////////////Heroes///////////////////////////");

            foreach (var personaje in personajes)
            {
                Console.WriteLine($"Nombre: {personaje.Name} Fuerza: {personaje.Strength} Agilidad: {personaje.Agility} Magia: {personaje.Magic}");
            }

            Console.WriteLine("///////////////////Enemigos///////////////////////////");
            List<Enemigo> enemigos = new List<Enemigo>();
            enemigos.Add(new Enemigo("Obito", 100, 87));
            enemigos.Add(new Enemigo("Mahito", 78, 47));
            enemigos.Add(new Enemigo("Kaguya", 84, 14));

            foreach (var enemigo in enemigos)
            {
                Console.WriteLine($"Nombre: {enemigo.Name} Vida: {enemigo.Life} Nivel: {enemigo.Level}");
            }

            Turno.Atacarse(personajes);
            Turno.MoverFichas(personajes[1]);
            Turno.MoverFichas(enemigos[1]);
        }
    }
}