using System;

class Program
{
    static void Main()
    {
        string triangulo= "triangulo";
        string cuadrado="cuadrado";
        string rectangulo="rectangulo";
       
        Console.Write("Por favor, ingrese su Figura: ");
        string figura = Console.ReadLine();
        if (figura == triangulo){
            Console.Write("Por favor, ingrese el valor de la altura: ");
            int altura = int.Parse(Console.ReadLine());
            Console.Write("Por favor, ingrese el valor de la base: ");
            int bas = int.Parse(Console.ReadLine());
            int area = bas * altura / 2;
            Console.Write("El area del triagulo es igual a:" + area);
        }
        else if (figura == cuadrado)
            {
                Console.WriteLine("Ingrese El valor de los lados:");
                int lado = int.Parse(Console.ReadLine());
                int areaCuadrado = lado * lado;
                Console.Write("El valor del are del cuadrado es:" + areaCuadrado);
            }

            else if (figura==rectangulo)
            {
                Console.WriteLine("Ingrese el valor de la altura del rectangulo");
                int alturaRec = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la base del Rectangulo");
                int baseRec = int.Parse(Console.ReadLine());
                int AreRec = alturaRec * baseRec;
                Console.Write("El area del Rectangulo es igual a:" + AreRec);



            }
            else
            {
                Console.WriteLine("Ingrese una figura valida ");


            }
        }




}





