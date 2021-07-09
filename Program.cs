using System;

namespace T4Eje6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /************
             * Ejercicio 6
             * **********/
            double precio=0;
            bool entrada = false;
            do
            {
                try
                {
                    Console.WriteLine("Indique precio del producto: ");
                    precio = Convert.ToDouble(Console.ReadLine());
                    entrada = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar un valor numerico.");
                }
            } while (!entrada);


            if (entrada)
            {
                if (precio > 0)
                {

                    string cuenta;
                    bool opcion = false;
                    do
                    {
                        Console.WriteLine("Indique forma de pago, tarjeta/efectivo:");
                        string texto = Console.ReadLine().ToLower();
                        switch (texto)
                        {
                            case "tarjeta":
                                Console.WriteLine("Indique numero de cuenta.");
                                cuenta = Console.ReadLine();
                                Console.WriteLine("Compra realizada con exito.");
                                opcion = true; break;
                            case "efectivo":
                                Console.WriteLine("Gracias por su compra.");
                                opcion = true; break;
                            default:
                                Console.WriteLine("Opcion incorrecta, indique tarjeta o efectivo");
                                opcion = false;
                                break;
                        }

                    } while (!opcion);
                }
            }
        }
    }
}
