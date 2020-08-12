using System;

namespace Calculadora
{
    class Program
    {            
        static void Main(string[] args)
        {
            onMenu();

            toMenu();
        }
        
        static void onMenu()
        {
            int seleccion;

            Console.WriteLine("                   Inicio");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- División");
            Console.WriteLine("5.- Cerrar");
            seleccion = Convert.ToInt32(Console.ReadLine());
            
            switch (seleccion)
            {
                case 1:
                    sumar();
                    break;
                case 2:
                    restar();
                    break;
                case 3:
                    multiplicar();
                    break;
                case 4:
                    dividir();
                    break;
                case 5:
                    closeProgram();
                    break;
            }
        }

        static void sumar()
        {
            double a, b;
            clean();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.WriteLine("El resultado de {0} + {1} = {2}", a, b, (a + b));
            Console.ReadKey();
            clean();
        }

        static void restar()
        {
            double a, b;
            clean();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.WriteLine("El resultado de {0} - {1} = {2}", a, b, (a - b));
            Console.ReadKey();
            clean();
        }

        
        static void multiplicar()
        {
            double a, b;
            clean();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.WriteLine("El resultado de {0} * {1} = {2}", a, b, (a * b));
            Console.ReadKey();
            clean();
        }

        static void dividir()
        {
            double a, b;
            clean();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            clean();
            Console.WriteLine("El resultado de {0} / {1} = {2}", a, b, (a / b));
            Console.ReadKey();
            clean();
        }
        static void closeProgram()
        {
            Console.WriteLine("Hasta Luego!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void clean() => Console.Clear();

        static void toMenu()
        {
            int volver;
            Console.WriteLine("Desea hacer otra operación?");
            Console.WriteLine("1.- Y");
            Console.WriteLine("2.- N");
            volver = Convert.ToInt32(Console.ReadLine());

            switch (volver)
            {
                case 1:
                    clean();
                    onMenu();
                    break;
                case 2:
                    closeProgram();
                    break;
            }
        }
    }
}
