using System;

namespace Ejercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND y OR....NOT
            //AND= Variable operador Variable && Variable operador Variable
            //En este caso se deben CUMPLIR AMBAS CONDICIONES
            // if(edad>10 && edad<30)
            //OR Operador: ||
            //OR= Variable operador Variable || Variable operador Variable
            // int edad=20;
            // char inicial='J';
            // if(edad>=20 && inicial=='J'){
            //     Console.WriteLine("21 OFF");
            // }
            //Switch: Codigo
                // int a = 3;
                // Switch(a){
                // case 1: 
                // Console.WriteLine("Hola");
                // break;
                // case 2:
                // Console.WriteLine("Chau");
                // break;
                // case 3:
                // Console.WriteLine("Blanco");
                // break;
                // case 4:
                // Console.WriteLine("Negro");
                // break;
                // default:
                // Console.WriteLine("Opción incorrecta");
                // break;

            // // Ejercicio 1: Hacer un programa que solicite el ingreso de dos números y 
            // // luego calcular:

            // // La resta si el primero es mayor que el segundo.
            // // La suma si son iguales.
            // // El producto si el primero es menor.

            // int n1, n2, resta, suma, producto;
            // Console.WriteLine("Ingrese un numero: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n2 = int.Parse(Console.ReadLine());
            // if(n1>n2){
            //     resta = n1 - n2; 
            //     Console.WriteLine(resta);
            // }
            // if(n1==n2){
            //     suma=n1+n2;
            //     Console.WriteLine(suma);
            // }
            // if(n1<n2){
            //     producto=n1*n2;
            //     Console.WriteLine(producto);
            // }
            
            // // 2. Un importante negocio de desinfectante líquido realiza 
            // // descuentos dependiendo de la cantidad de litros vendidos según 
            // // la siguiente escala:

            // // Si vende menos de 100 litros, no hay descuento.
            // // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // // Finalmente, si la venta es de más de 500 
            // // litros, el descuento es del 25%.
            // // Hacer un programa que solicite el ingreso del importe total
            // // de la venta y la cantidad de litros vendidos y calcule y emita el 
            // // importe con el descuento  aplicado..

            // float litros, importe, valorFinal;
            // Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            // litros = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el importe total de la venta: ");
            // importe = int.Parse(Console.ReadLine());
            // if(litros>500){
            //    valorFinal = importe * 0.75F;
            //    Console.WriteLine("El valor final de la venta es: " + valorFinal);

            // }
            // if(litros<=500 && litros>300){
            //     valorFinal = importe * 0.85F;
            //    Console.WriteLine("El valor final de la venta es: " + valorFinal);
            // }
            // if(litros<=300 && litros>100){
            //     valorFinal = importe * 0.9F;
            //    Console.WriteLine("El valor final de la venta es: " + valorFinal);
            // }
            // if(litros<=100){
            //     valorFinal = importe;
            //    Console.WriteLine("El valor final de la venta es: " + valorFinal);
            // }

            // Ejercicio 3: Una importante marca de computadoras permite elegir 
            // cierta configuración del equipo a comprar. Para ello existe la 
            // siguiente escala de precios:

            //              i5 (1)	     i7 (2)	        i9 (3)
            // 8 RAM (1)	USD 800	     USD 900	  USD 1200
            // 16 RAM (2)	USD 900	     USD 1000	  USD 1400
            // 32 RAM (3)	USD 1000	 USD 1400	  USD 2000
            // Además, el equipo viene con un disco que permite almacenar 500 GB
            // de información y que se puede ampliar a 1 TB si así lo desea, lo
            // cual tiene un costo  adicional de USD 300. Hacer un programa que 
            // solicite la opción de procesador, la opción de memoria  RAM, y si
            // extiende el disco o no (ingresa 1 para extender y 0 para no 
            // extender) y calcule y emita por pantalla el monto de la máquina 
            // seleccionada.

            // int procesador, ram, discoDuro; 
            // int precio=0;
            // Console.WriteLine("Ingrese opcion de procesador: 1=i5 - 2=i7 - 3=i9");
            // procesador=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese opcion de RAM: 1=8Gb = 2=16Gb - 3=32Gb");
            // ram=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese si extiende el disco: 1=Si 2=No" );
            // discoDuro=int.Parse(Console.ReadLine());

            // switch(procesador){
            //     case 1:
            //         switch(ram){
            //             case 1:
            //                 precio=800;
            //             break;
            //             case 2:
            //                 precio=900;
            //                 break;
            //             case 3:
            //                 precio=1000;
            //                 break;
            //              default:
            //                 Console.WriteLine("No coincide ninguna opcion");
            //                 break;
            //         }
            //         break;
            //     case 2:
            //         switch(ram){
            //             case 1:
            //                 precio=900;
            //             break;
            //             case 2:
            //                 precio=1000;
            //                 break;
            //             case 3:
            //                 precio=1400;
            //                 break;
            //              default:
            //                 Console.WriteLine("No coincide ninguna opcion");
            //                 break;      
            //         }
            //         break;
            //     case 3:
            //         switch(ram){
            //             case 1:
            //                 precio=1200;
            //             break;
            //             case 2:
            //                 precio=1400;
            //                 break;
            //             case 3:
            //                 precio=2000;
            //                 break;
            //             default:
            //                 Console.WriteLine("No coincide ninguna opcion");
            //                 break;
            //         } 
            //         break;
            //     default:
            //         Console.WriteLine("No coincide ninguna opcion");
            //         break;
            // }
            // if(discoDuro==1){
            //     precio=precio+300;
            //     Console.WriteLine("El precio final es: " + precio);
            // }
            // if(discoDuro==0){
            //     precio=precio+0;
            //     Console.WriteLine("El precio final es: " + precio);
            // }
            // if(precio==0){
            //     Console.WriteLine("No se ingresaron los parametros adecuados.");
            // }
            
            // Ejercicio 4: Hacer un programa para ingresar tres números y emitir un cartel
            // aclaratorio si la suma de los dos primeros es mayor al producto del 
            // segundo con el tercero.

            // int n1, n2, n3;
            // Console.WriteLine("Ingrese un numero: ");
            // n1=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n2=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n3=int.Parse(Console.ReadLine());
            // if((n1+n2)>(n2*n3)){
            //     Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
            // }
            // if((n1+n2)<(n2*n3)){
            //     Console.WriteLine("La suma de los dos primeros NO es mayor al producto del segundo con el tercero");
            // }

            // Ejercicio: Hacer un programa para ingresar 4 números. Luego analizar e informar
            // por pantalla si los mismos se encuentran ordenados de forma decreciente 

            // int n1, n2, n3, n4;
            // Console.WriteLine("Ingrese un numero: ");
            // n1=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n2=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n3=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese un numero: ");
            // n4=int.Parse(Console.ReadLine());
            // if(n1>2){
            //     if(n2>n3){
            //         if(n3>n4){
            //             Console.WriteLine("Los numeros se encuentran ordenados de forma decreciente");
            //         }
            //     }
            // }
            // else{
            //     Console.WriteLine("No estan ordenados de forma decreciente");
            // }

            



        }





     }
}

