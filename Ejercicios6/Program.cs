using System;

namespace Ejercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. El mismo debe 
            // analizar y mostrar por pantalla cuántos de esos números son primos.
            // int a,con=0,acu;
            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     a=int.Parse(Console.ReadLine());
            //     acu=0;
            //     for(int i = 1; i<=a; i++ )
            //     {
            //         if((a%i)==0){
            //             acu++;
            //         }
            //     }
            //     if(acu==2)
            //     {
            //         con++;
            //     }
            // }
            // Console.WriteLine("El numero de primos es: " + con);


            // 2. Se dispone de una lista de 5 listas de números enteros 
            // separados entre ellos por ceros. Se pide determinar e informar:

            // -El número de grupo con mayor porcentaje de números impares 
            // respecto al total de números que forman el grupo.

            // -Informar cuántos grupos están formados por todos 
            // números ordenados de mayor a menor.

            // int n,contNumeros,contImpares,grupoMaximo=0,min,contadorMin=0;
            // double porcentajeMaximo=-1,porcentajeImpar;
            // bool banderaOrdenados;
            // for (int x = 0; x < 5; x++)
            // { 
            //     contNumeros=0;
            //     contImpares=0;
            //     banderaOrdenados=true;
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     min=n;
            //     while (n != 0)
            //     {
            //         contNumeros++;
            //         if((n%2)!=0)
            //             contImpares++;
                    
            //         if(n<=min)
            //             min=n;
            //         else
            //             banderaOrdenados=false;
            //         Console.WriteLine("Ingrese un numero: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     porcentajeImpar=(contImpares*100)/contNumeros;
            //     if(porcentajeImpar>porcentajeMaximo){
            //         porcentajeMaximo=porcentajeImpar;
            //         grupoMaximo=x+1;
            //     }
            //     if(banderaOrdenados==true)
            //         contadorMin++;

            // }
            // Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoMaximo);
            // Console.WriteLine("El numero de grupos ordenados es: " + contadorMin);

            // 3. Hacer un programa para recibir listas de números positivos 
            // que están separadas entre sí por un cero. El fin de la carga se notifica
            // con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n=1,cont,contadorGrupo=0;

            while(n>=0)
            {
                contadorGrupo++;
                cont=0;
                Console.WriteLine("Ingrese un numero: ");
                n=int.Parse(Console.ReadLine());
                while(n!=0 && n>0)
                {
                    if(n>0)
                    {
                        cont++;
                    }
                    Console.WriteLine("Ingrese un numero: ");
                    n=int.Parse(Console.ReadLine());
                }
                Console.WriteLine("El grupo " + contadorGrupo + " tiene la siguiente cantidad de numeros: " + cont);
            }
        }
    }
}
