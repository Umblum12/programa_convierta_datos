using System;

namespace programa_convierta_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dato

            //Enteros estos son valores sin punto flotante o decimal
            //ejemplo 6.7 3.1416

            byte bt = 255;
            short sh = 32767; // scope [el alcance de las variables]
            int entero = 2131124123;
            long l = 12312371123;

            // con punto flotante

            float f1 = 3.1416F; // importante F
            double d1 = 45.124231;

            bt = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para byte es: " + bt);

            sh = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para short es: " + sh);

            entero = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para int es: " + entero);

            l = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para long es: " + l);

            f1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para float es: " + f1);

            d1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para double es: " + d1);
            Console.ReadKey(true);
        }
    }
}
