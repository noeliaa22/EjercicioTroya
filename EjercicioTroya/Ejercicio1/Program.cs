using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
               
                7. Buscar  a Odiseo en el caballo y comprobar que no existe.
                8. Crear 1 guerrero troyano (Paris ).
                9. Montarlo en el caballo y comprobar que no es posible.*/

            //Troyano troyano = new Troyano();
            //2. Crear un caballo con capacidad para 20 guerreros.
            Caballo caballo = new Caballo(20);

            //3. Crear 3  guerreros griegos (Aquiles, Agamenon y Ajax) y montarlos en el caballo. 
            Griego griego1 = new Griego("Aquiles",20,9);
            Griego griego2 = new Griego("Agamenon",30,7);
            Griego griego3 = new Griego("Ajax",56,5);
            caballo.MontarseEnCaballo(griego1);
            caballo.MontarseEnCaballo(griego2);
            caballo.MontarseEnCaballo(griego3);

            // 4. Mostrar caballo.
            caballo.MostrarCaballo();

            //5. Crea otro guerrero griego anónimo y montalo en el caballo y muestra el caballo.
            Griego griego4 = new Griego();
            caballo.MontarseEnCaballo(griego4);
            caballo.MostrarCaballo();

            // 6. Buscar a Agamenon en el caballo y mostrar sus datos

        }
    }
}
