using System;

namespace TPFinal_GonzalezQuintana
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n, mayorPar=0, cantidadImpares=0,menorPrimo=0;
            int banderaPar=0, banderaPrimo=0;
            bool esPrimo;
            Console.WriteLine("Ingrese un número (corta cuando ingrese un 0): ");
            n = int.Parse(Console.ReadLine());
            while(n!=0){
                if((n%2)==0 && banderaPar==0){
                    mayorPar=n;
                    banderaPar=1;
                }
                else if((n%2)==0 && n>mayorPar){
                    mayorPar=n;
                }
                else if((n%2)!=0){
                    cantidadImpares++;
                }
                esPrimo = primo(n);
                if(esPrimo==true && banderaPrimo==0){
                    menorPrimo=n;
                    banderaPrimo=1;
                }
                else if(esPrimo==true && menorPrimo>=n){
                    menorPrimo=n;
                }
                Console.WriteLine("Ingrese un nuevo número: ");
                n = int.Parse(Console.ReadLine());
            }
            if(mayorPar!=0){
                Console.WriteLine("El mayor de los número pares ingresados es: " + mayorPar);
            }
            else{
                Console.WriteLine("No se ingresaron números pares");
            }
            if(cantidadImpares!=0){
                Console.WriteLine("La cantidad números de impares ingresados es: " + cantidadImpares);
            }
            else{
                Console.WriteLine("No se ingresaron números impares");
            }
            if(menorPrimo>0){
                Console.WriteLine("El menor de los números primos ingresados es: " + menorPrimo);
            }
            else{
                 Console.WriteLine("No se ingresaron numeros primos");
            }
        }
        static bool primo(int a){
            int contador=0;
            bool r;
            for(int x=1; x<=a; x++){
                if(a%x==0){
                    contador++;
                }
            }
            if(contador==2){
                r=true;
                return r;
            }
            else{
                r=false;
                return r;
            }
    }   }
}
