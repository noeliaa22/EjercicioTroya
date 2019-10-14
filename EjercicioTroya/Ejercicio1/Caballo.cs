using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio1
{
    class Caballo
    {
        public int NumeroGuerreros { get; } //No se podrá cambiar una vez le hemos dado valor.
        public int Ocupacion { get; set; }
        public List<Griego> Ocupantes { get; set;}


        //Crear un constructor para la clase Caballo con espacio para 
        //tantos guerreros como indique el parámetro que se pasa a dicho constructor. 
        public Caballo(int numeroGuerreros)
        {
            NumeroGuerreros = numeroGuerreros;
            Ocupantes = new List<Griego>(); //IMPORTANTE DECLARAR LA LISTA, sino da error
            Ocupacion = 0;
        }


        //busque por su nombre un guerrero dentro de la lista ocupantes y devuelva la posición en que está ó -1 si no está
        public int BuscarNombre(string nombre)
        {
            int posicion=-1;
            foreach (Griego item in Ocupantes)
            {
                if(item.Nombre == nombre)
                {
                    posicion = Ocupantes.IndexOf(item);
                }
            }
            return posicion;
        }

        //Si la posición es válida, muestra en pantalla los datos del guerrero de posición pos. 
        //Y si no indica que no es posible.
        public void MostrarGuerreroPosicion(int posicion)
        {

                if (posicion<=Ocupantes.Count)
                {
                    Console.WriteLine(Ocupantes[posicion]);
                }
                else
                {
                    Console.WriteLine($"El griego de la posición {posicion} no existe");
                }

            }


        //reciba como parámetro un Griego y lo meta en la lista de ocupantes (si hay sitio). 
        public void MontarseEnCaballo(Griego griego)
        {
            Ocupacion++;
            if (Ocupacion<NumeroGuerreros)
            {
                Ocupantes.Add(griego);
                Console.WriteLine($"Guerrero Griego {griego.Nombre} montado en caballo");
            }
            else
            {
                Console.WriteLine("No hay sitio");
            }
        }

        //que muestra en pantalla la información relativa:
	//-Capacidad, ocupación y lista de ocupantes con sus datos.
    public void MostrarCaballo()
        {
            Console.WriteLine($"\n*************************************************");
            Console.WriteLine($"La capacidad es de {NumeroGuerreros} guerreros \n");
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"Actualmente hay una ocupación de {Ocupacion} guerreros \n");
            Console.WriteLine($"*************************************************");
            foreach (Griego item in Ocupantes)
            {
                Console.WriteLine("Nombre:"+item.Nombre+"\nEdad:"+item.Edad+"\nFuerza:"+item.Fuerza+"\n\n");
            }

        }


    }
}

