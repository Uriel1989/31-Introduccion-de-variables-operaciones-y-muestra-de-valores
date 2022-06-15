using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _31_OperacionesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            double num2;

            char letra = 'A';
            

            num1 = 29;
            num2 = 12.2;

            double suma = num1 + num2;

            double resta = num2 - num1;

            Console.WriteLine("Se han ingresado los valores: " + num1 + " y " + num2 + " se los ha sumado y restado");

            Console.WriteLine("El resultado de la suma de es: " + suma + Environment.NewLine + "El resultado de la resta es: " + resta);

            Console.WriteLine("Tambien se ha ingresado una variable de tipo CHAR cuyo valor es: " + letra);


            Console.ReadKey();



        }
    }
}
