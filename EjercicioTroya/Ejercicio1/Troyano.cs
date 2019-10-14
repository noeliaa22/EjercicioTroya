using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Troyano
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Fuerza { get; set; }
        public bool Herido { get; set; }
        public bool Muerto { get; set; }


        //Constructor de todos los valores
        public Troyano(string nombre, int edad, int fuerza, bool herido, bool muerto)
        {
            Nombre = nombre;
            Edad = edad;
            Fuerza = fuerza;
            Herido = herido;
            Muerto = muerto;
        }


        //Constructor: recibirá valores para todos los atributos, excepto herido y muerto, que obviamente serán falsos. 
        //Deberá comprobar que los valores dados son válidos y en caso contrario poner como edad 25 y como fuerza 5.
        public Troyano(string nombre, int edad, int fuerza)
        {
            Nombre = nombre;
            if (ComprobarEdad()==true)
            {
            Edad = edad;
            }
            else
            {
                Edad = 25;
            }

            if (ComprobarFuerza()==true)
            {
            Fuerza = fuerza;
            }
            else
            {
                Fuerza = 5;
            }

            Herido = false;
            Muerto = false;
        }

        //Crea un segundo constructor sin parámetros que ponga como nombre “TroyanoX”, edad 18 y fuerza 10.
        public Troyano()
        {
            Nombre = "TroyanoX";
            Edad = 18;
            Fuerza=10;
            Herido = false;
            Muerto = false;
        }


        public bool Retirarse()
        {
            Console.WriteLine("Acción: Retirarse \n");
            Console.WriteLine($"Troyano: {Nombre}");
            Console.WriteLine($"Edad: {Edad} \t Fuerza: {Fuerza}");
            if (Herido && !Muerto)
            {
            Console.WriteLine($"Está herido --> Los Guerreros Troyanos NUNCA se retiran!!!");
            return true;
            }
            return false;
        }


        //Comprobar edad: devuelva true si la edad está entre 15 y 60 (ambos inclusive), false en caso contrario.
        public bool ComprobarEdad()
        {
            bool edadCorrecta = false;
            if (Edad >= 0)
            {
                if (Edad >= 15 && Edad <= 60)
                {
                    edadCorrecta= true;
                }
                else
                {
                }
            }
            else
            {
                Console.WriteLine("La edad introducida no es correcta");
            }
            return edadCorrecta;
        }

        //Comprobar fuerza: que devuelve true si la fuerza está entre 1 y 10 (ambos inclusive), false en caso contrario.
        public bool ComprobarFuerza()
        {
            bool fuerzaCorrecta = false;
            if (Fuerza >= 0)
            {
                if (Fuerza >= 1 && Fuerza <= 10)
                {
                    fuerzaCorrecta = true;
                }
                else
                {
                }
            }
            else
            {
                Console.WriteLine("El valor de la fuerza tiene que ser positivo");
            }
            return fuerzaCorrecta;
        }

    }


    }

