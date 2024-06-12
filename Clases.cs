
namespace libreriaClases{

    class perro{

       public string raza;
       public string nombre;
        public int edad;
        public string tamano;


       public void jugar(string pJugar) {

            Console.WriteLine("Jugando......" + pJugar);

        }

        public string ladrar() {

            return  "guau guau....";

        }

        public void mostrarAtributos(){
            Console.WriteLine("Nombre: {0}",nombre);
            Console.WriteLine("Raza: {0}",raza);
            Console.WriteLine("Edad: {0}",edad);
            Console.WriteLine("Tamaño: {0}",tamano);
        }

    }
}



