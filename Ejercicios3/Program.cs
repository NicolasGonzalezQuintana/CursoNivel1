using System;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa 1: Hacer un programa para ingresar un número y luego se 
            // emita por pantalla un cartel aclaratorio si 
            // “Es mayor a 10” o “No e/s mayor a 10”.
            // // int n1;
            // // Console.WriteLine("Ingrese un numero: ");
            // // n1 = int.Parse(Console.ReadLine());
            // // if(n1>10){
            // //     Console.WriteLine("Es mayor a 10");
            // // }else{
            // //     Console.WriteLine("No es mayor a 10");
            // // }
            // // Console.WriteLine("Fin del programa");


            // // Programa 2: Hacer un programa para ingresar un número y luego se 
            // // emita un cartel por pantalla “Positivo” si el número es mayor a 
            // // cero, “Negativo” si el número es min a cero o “Cero” 
            // // si el número es igual a cero.
            // int n1;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // if(n1==0){
            //     Console.WriteLine("El numero es igual a 0");
            // }else if(n1>0){
            //     Console.WriteLine("El numero es positivo");
            // }else{
            //     Console.WriteLine("El numero es negativo");
            // }
            // Console.WriteLine("Fin del programa");



            // // Programa 3: Una casa de video juegos otorga un descuento 
            // // dependiendo del importe de la compra realizada según los 
            // // siguientes valores:

            // // Si el importe es min a ARS 1000, no hay descuento.
            // // Si el importe es ARS 1000 o más pero min a ARS 5000, aplica 
            // // un descuento del 10%.
            // // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // // Hacer un programa para ingresar un importe de venta y luego muestre 
            // // por pantalla el importe final con el descuento que corresponda.

            // int importe;
            // float ValorFinal;
            // Console.WriteLine("Ingrese el importe de la compra: ");
            // importe = int.Parse(Console.ReadLine());
            // if(importe>=5000){
            //     ValorFinal=importe + (importe * 0.18F);
            // }else if(importe>=1000){
            //     ValorFinal=importe + (importe * 0.10F);
            // }else{
            //     ValorFinal=importe;
            // }
            // Console.WriteLine("El valor con descuento aplicado: " + ValorFinal);


            // // Programa 4: Hacer un programa para ingresar cuatro números distintos 
            // // y luego mostrar por pantalla el min de ellos.
            // int n1, n2, n3, n4;
            // int bandera=0;
            // int min=0;
            // Console.WriteLine("Ingrese un numero: ");
            // n1=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n2=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n3=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n4=int.Parse(Console.ReadLine());
            // if(bandera==0){
            //     bandera = 1;
            //     min = n1;
            // }
            // if(n2 < min){
            //     min = n2;
            // }
            // if(n3 < min){
            //     min = n3;
            // }
            // if(n4<min){
            //     min=n4;
            // }
            // Console.WriteLine("El minimo es: " + min);


            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por 
            // pantalla cuáles son mayores a 100.
            
            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese un numero: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            n3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            n4=int.Parse(Console.ReadLine());
            if(n1>100){
                Console.WriteLine(n1 + " Es mayor a 100");
            }
            if(n2>100){
                Console.WriteLine(n2 + " Es mayor a 100");
            }
            if(n3>100){
                Console.WriteLine(n3 + " Es mayor a 100");
            }
            if(n4>100){
                Console.WriteLine(n4 + " Es mayor a 100");
            }
        }  
    }
}
