using System;

namespace Ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 1. Hacer un programa para mostrar los números del 1 al 10.
            // // No se debe realizar ningún pedido de datos.
            // int x;
            // for(x=0; x<10; x++){
            //     Console.WriteLine(x+1);
            // }
            
            
            // // 2. Hacer un programa que solicite el ingreso de 10 números
            // // y que muestre el mayor de ellos por pantalla. 
            // // Solo se debe emitir UN valor por pantalla.
            // int x, n;
            // int mayor=0;
            // int bandera=0;
            // for(x=0; x<10 ; x++){
            //     Console.WriteLine("Ingrese un numero: ");
            //     n=int.Parse(Console.ReadLine());
            //     if(bandera==0){
            //         mayor=n;
            //         bandera=1;
            //     }
            //     if(n>mayor){
            //         mayor=n;
            //     }
            // }
            // Console.WriteLine("El numero mayor es: " + mayor);

            // 3. Hacer un programa que solicite 20 edades y luego calcule el 
            // promedio de edad de aquellas personas mayores a 18 años
            // int n, promedio, x, acumulador=0, contador=0;
            // for(x=0; x<10; x++){
            //     Console.WriteLine("Ingrese un nro:");
            //     n=int.Parse(Console.ReadLine());
            //     if(n>18){
            //         contador++;
            //         acumulador+=n;
            //     }
            // }
            // if(contador>0){
            //     promedio=acumulador/contador;
            //     Console.WriteLine("El promedio es: " + promedio);
            // }else{
            //     Console.WriteLine("No hay numeros mayores a 18");
            // }

            // 4. Hacer un programa que solicite UN número y luego calcule y emita un 
            // cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo 
            // cuando es divisible únicamente por 1 y por sí mismo.
            
            // int n,x,contador=0;
            // Console.WriteLine("Ingrese un numero; ");
            // n=int.Parse(Console.ReadLine());
            // for(x=1; x<=n; x++){
            //     if((n % x)==0){
            //         contador++;
            //     }
            // }
            // if(contador==2){
            //     Console.WriteLine("El numero es primo");
            // }else{
            //     Console.WriteLine("El numero no es primo");
            // }


            // // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el
            // // máximo de los números pares y el mínimo de los números impares.
            // int x, n, minimoImpar=0,maximoPar=0,banderaPar=0, banderaImpar=0;
            // for(x=0;x<10;x++){
            //     Console.WriteLine("Ingrese un numero: ");
            //     n=int.Parse(Console.ReadLine());
            //     if((n%2)==0){
            //         if(banderaPar==0){
            //             maximoPar=n;
            //             banderaPar=1;
            //         }else if(n>maximoPar){
            //             maximoPar=n;
            //         }
                    
            //     }
            //     if((n%2)!=0){
            //         if(banderaImpar==0){
            //             minimoImpar=n;
            //             banderaImpar=1;
            //         }else if(n<minimoImpar){
            //             minimoImpar=n;
            //         }
            //     }
            // }
            // Console.WriteLine("El maximo par es:" + maximoPar);
            // Console.WriteLine("El minimo impar es: " + minimoImpar);


        }
    }
}
