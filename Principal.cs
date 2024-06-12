using System;
using libreriaClases;
namespace principal {
    class programaPrincipal{
            static public void Main(){
                
                string nombre;
                nombre = "juan";
                perro firulai;

                firulai = new perro();

                perro pedro = new perro();

                Console.WriteLine("Hola");

                firulai.edad = 2;

                firulai.tamano = "grande";
                firulai.nombre = "Firulais";

                firulai.raza = "caniche";

                firulai.jugar("saltar");
                firulai.jugar("domirse");

                Console.WriteLine(firulai.ladrar());

                pedro.edad = 4;
                pedro.nombre = "Pedro";
                pedro.raza = "salchicha";
                pedro.tamano = "mediano";

                pedro.mostrarAtributos();


                firulai.mostrarAtributos();

            }
    }
}
