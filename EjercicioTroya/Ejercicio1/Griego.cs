using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Griego
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Fuerza { get; set; }
        public bool Herido { get; set; }
        public bool Muerto { get; set; }

        public Griego(string nombre, int edad, int fuerza)
        {
            Nombre = nombre;
            Edad = edad;
            Fuerza = fuerza;
        }

        public Griego()
        {
            Nombre = "GriegoX";
            Edad = 20;
            Fuerza = 8;
            Herido = false;
            Muerto = false;
        }
        public bool ComprobarEdad(int edad)
        {
            bool edadCorrecta = false;
            if (edad >= 0)
            {
                if (edad >= 15 && edad <= 60)
                {
                    edadCorrecta = true;
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
        public bool ComprobarFuerza(int fuerza)
        {
            bool fuerzaCorrecta = false;
            if (fuerza >= 0)
            {
                if (fuerza >= 1 && fuerza <= 10)
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
        public bool Retirarse()
        {
            bool retirarse = false;
            if (Herido==true && Muerto==false)
            {

            retirarse = true;
            Console.WriteLine("Acción: Retirarse \n");
            Console.WriteLine($"Griego: {Nombre}");
            Console.WriteLine($"Edad: {Edad} \t Fuerza: {Fuerza}");
            Console.WriteLine($"Está herido --> RETIRADA");
            }
            else
            {
            }
            return retirarse;
        }

    }
}
