// See https://aka.ms/new-console-template for more information

using Practica_hotfix.Clases;

namespace Practica_hotfix
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje
        {
            Nombre = "Guerrero",
            Vida = 10,
            Ataque = 20,
            Defensa = 10,
            Nivel = 1
        };

            Console.WriteLine();
            Console.WriteLine("Nombre: " + personaje.Nombre);
            Console.WriteLine("Vida: " + personaje.Vida);
            Console.WriteLine("Ataque: " + personaje.Ataque);
            Console.WriteLine("Defensa: " + personaje.Defensa);
            Console.WriteLine("Nivel: " + personaje.Nivel);
            Console.ReadLine();
        }
    }
}