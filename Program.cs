using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia1Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Promedio de edades: Pregunta 
            //Ingresa las edades de tres personas y calcula el promedio de edad.
            Console.WriteLine("Calculo de promedio de edades");
            int edad1 = 15, edad2 = 23, edad3 = 42;
            double sumatoria = (edad1 + edad2 + edad3) / 3;

            Console.WriteLine("el promedio es " + sumatoria);
            //Forma alternativa
            //Console.WriteLine($"El promedio es {sumatoria}");
            Console.WriteLine("las 3 edades son {0} {1} {2}", edad1, edad2, edad3);

            //2
            //Area de un rectangulo:
            //Ingresa la base y la altura de un rectangulo y calcula su area.
            double vBase, vAltura;
            
            Console.WriteLine("Ingrese la base");
            vBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            vAltura = int.Parse(Console.ReadLine());

            double area = (vBase * vAltura);

            Console.WriteLine("el area del rectangulo es " + area);

            //3
            //Descuento de una tienda:
            //Ingresa el precio original de un producto y el procentaje de descuento aplicado
            //Calcula el precio con descuento y muestra el resultado.
            double precioOriginal, porcentajeDes, precioConDesc;
            
            Console.WriteLine("Ingrese el precio");
            precioOriginal = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el descuento ej 30.5");
            porcentajeDes = double.Parse(Console.ReadLine());
            
            precioConDesc = precioOriginal - (porcentajeDes * precioOriginal / 100);
            
            Console.WriteLine("El precio final es: "+ precioConDesc);

            //4
            //Edades y sumatoria
            //Ingrese las edades de tres personas y calcula la sumatoria de edad. 
            int sumatoriaEdad;

            Console.WriteLine("Calculo de promedio de edades");
            
            Console.WriteLine("Ingrese edad 1");
            edad1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese edad 2");
            edad2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese edad 3");
            edad3 = int.Parse(Console.ReadLine());
            
            sumatoriaEdad = edad1 + edad2 + edad3;
            Console.WriteLine("La sumatoria de las edades es: " + sumatoriaEdad);

            //5
            //Temperatura en grados Fahrenheit:
            //Ingresa una temperatura en grados celsius y conviertela a grados Fahrenheit.
            int tempCelsius, tempFahren;

            Console.WriteLine("Ingrese la temperatura en grados celsius");
            tempCelsius = int.Parse(Console.ReadLine());
            tempFahren = tempCelsius + 32;
            Console.WriteLine("La temperatura equivalente en grados fahrenheit es: " + tempFahren);

            //6
            //Altura en pulgadas:
            //Ingresa la altura en metros de una persona y muestra su equivalente en pulgadas.
            double metrosPersona, pulgadasPersona;

            Console.WriteLine("Ingrese los metros de la persona");
            metrosPersona = double.Parse(Console.ReadLine());
            pulgadasPersona = metrosPersona * 39.37;
            Console.WriteLine("El equivalente a pulgadas es " + pulgadasPersona + " pulgadas");

            Console.ReadLine();
        }
    }
}
