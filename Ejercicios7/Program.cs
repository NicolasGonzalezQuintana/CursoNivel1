using System;

namespace Ejercicios7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite 10 números enteros y 
            // los guarde en un vector. Luego recorrer los elementos y 
            // determinar e informar cuál es el valor máximo y su posición dentro del vector.

            // int n, maximo=0, bandera=0, posicion=0;
            // int[] numeros = new int[10];

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n=int.Parse(Console.ReadLine());
            //     numeros[x]=n;
            // }
            // for (int i = 0; i <10; i++)
            // {
            //     if(bandera==0){
            //         bandera=1;
            //         maximo=numeros[i];
            //     }
            //     else if(numeros[i]>maximo){
            //         maximo=numeros[i];
            //         posicion=(i+1);
            //     }
            // }
            // Console.WriteLine("El valor maximo corresponde: " + maximo + " en la posicion " + posicion);


            // 2. Hacer un programa que solicite 10  números enteros y los 
            // guarde en un vector. Luego recorrer ese vector para calcular
            // el promedio. Mostrar por pantalla los valores que son mayores
            // al promedio.
            
            // int n, promedio,acumulador=0;
            // int[] numeros=new int[10];
            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n=int.Parse(Console.ReadLine());
            //     numeros[x]=n;
            // }
            // for (int i = 0; i <10; i++)
            // {
            //     acumulador+=numeros[i];
            // }
            // promedio=acumulador/10;
            // Console.WriteLine("EL promedio es: " + promedio);
            // for (int y = 0; y < 10; y++)
            // {
            //     if(numeros[y]>promedio){
            //         Console.WriteLine(numeros[y] + " es mayor al promedio");
            //     }
            // }

            // 3. Hacer un programa que solicite una cadena de caracteres
            // y dos caracteres sueltos (tres ingresos). El programa deberá 
            // generar una cadena donde todas las ocurrencias del primer carácter
            // dado hayan sido reemplazadas por el segundo. Mostrar el 
            // resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"
          
            // char[] frase=new char[15];
            // char letraActual;
            // char letraNueva;
            // int indice=0;
            // char letra;
            // Console.WriteLine("Ingrese un caracter; ");
            // letra=char.Parse(Console.ReadLine());
            // while(letra!='0' && indice<30){
            //     frase[indice]=letra;
            //     Console.WriteLine("Ingrese otro caracter; ");
            //     letra=char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // frase[indice]='\0';
            // Console.WriteLine("La frase completa es: ");
            // indice=0;
            // while(frase[indice]!='\0'){
            //     Console.Write(frase[indice]);
            //     indice++;
            // }
            // Console.WriteLine("Ingrese caracter que quiera cambiar: ");
            // letraActual=char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese nuevo caracter: ");
            // letraNueva=char.Parse(Console.ReadLine());
            // indice=0;
            // while(frase[indice]!='\0'){
            //     if(frase[indice]==letraActual){
            //         frase[indice]=letraNueva;
            //     }
            //     indice++;
            // }
            // Console.WriteLine("La nueva frase es: ");
            // indice=0;
            // while(frase[indice]!='\0'){
            //     Console.Write(frase[indice]);
            //     indice++;
            // }


            

            // char letra1, letra2;
            // string cadena;
            // Console.WriteLine("Ingrese una frase: ");
            // cadena=Console.ReadLine();
            // Console.WriteLine("Ingrese una letra; ");
            // letra1=char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otra letra; ");
            // letra2=char.Parse(Console.ReadLine());  
            // cadena=cadena.Replace(letra1, letra2);
            // Console.WriteLine("La frase nuev a es: ");
            // Console.WriteLine(cadena);

            // 4. Una empresa comercializa 15 tipos de artículos y por 
            // cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el 
            // último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.
            
            // int articulo, cantidad;
            // int[] cantidadVendida= new int[15];
            // for (int x = 0; x < 15; x++)
            // {
            //     cantidadVendida[x]=0;
            // }
            // Console.WriteLine("ingrese numero de articulo(1-15): ");
            // articulo=int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la cantidad vendida");
            // cantidad=int.Parse(Console.ReadLine());
            // while(articulo!=0)
            // {
            //     cantidadVendida[articulo-1]+=cantidad;
            //     Console.WriteLine("ingrese numero de articulo(1-15): ");
            //     articulo=int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese la cantidad vendida");
            //     cantidad=int.Parse(Console.ReadLine());
            // }
            // int masVendido=cantidadVendida[0];
            // articulo=1;
            // for (int x = 0; x < 15; x++)
            // {
            //     if(cantidadVendida[x]>masVendido){
            //         masVendido=cantidadVendida[x];
            //         articulo=x+1;
            //     }
            //     else if(cantidadVendida[x]==0){
            //         Console.WriteLine("El articulo " + (x+1) + " no registro ventas");
            //     }
            // }
            // Console.WriteLine("El producto mas vendido fue el: " + articulo);
            // Console.WriteLine("El articulo 10 registro " + (cantidadVendida[9]) + " de ventas");
        }
    }
}
