using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34
{
//34. Crear las clases Automovil, Moto y Camion.
//a. Crear un enumerado Colores { Rojo, Blanco, Azul, Gris, Negro }
//b. Camión tendrá los atributos cantidadRuedas : short, cantidadPuertas : short, color : Colores,
//cantidadMarchas : short, pesoCarga : int.
//c. Automovil: cantidadRuedas : short, cantidadPuertas : short, color : Colores,
//cantidadMarchas : short, cantidadPasajeros : int.
//d. Moto: cantidadRuedas : short, cantidadPuertas : short, color : Colores, cilindrada : short.
//e. Crearle a cada clase un constructor que reciba todos sus atributos.
//f. Crear la clase VehiculoTerrestre y abstraer la información necesaria de las clases anteriores.
//Luego generar una relación de herencia entre ellas, según corresponda.
//g. VehiculoTerrestre tendrá un constructor que recibirá todos sus atributos. Modificar las
//clases que heredan de ésta para que lo reutilicen.
//Generar el código en el Main para probar las clases.
    class Ejercicio34
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(4, 5, Colores.Rojo, 3, 5);
            Camion camion = new Camion(16, 2, Colores.Negro, 4000, 6);
            Moto moto = new Moto(2, 0, Colores.Azul, 650);

            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n","VEHICULO","RUEDAS","PUERTAS","COLOR","MARCHAS","ESPECIAL");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n","CAMION",camion.CantidadRuedas, camion.CantidadPuertas, camion.Color, camion.CantidadMarchas, "Peso Carga: "+camion.PesoCarga);
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n","AUTO"  ,auto.CantidadRuedas, auto.CantidadPuertas, auto.Color, auto.CantidadMarchas, "Cant Pasajeros: "+auto.CantidadPasajeros);
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n","MOTO"  ,moto.CantidadRuedas, moto.CantidadPuertas, moto.Color, 0, "Cilindrada: "+ moto.Cilindrada);

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
