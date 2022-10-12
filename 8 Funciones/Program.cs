using System;

namespace Ejercicios8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba
            //dos números enteros y que devuelva el producto de 
            //ambos. Luego hacer un programa que pida el precio de
            //un artículo y la cantidad vendida y muestre por pantalla 
            //el monto total a pagar. Usar la función.
            // int n1, n2, resultado;
            
            // Console.WriteLine("Ingrese un número: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese otro número: ");
            // n2 = int.Parse(Console.ReadLine());
            // resultado=producto(n1, n2);
            // Console.WriteLine("El resultado es: " + resultado);

            // 2. Hacer una función llamada “par” que reciba un número
            // entero y devuelva 1 si es par o cero si no lo es. Hacer un
            // programa para ingresar 20 números y mostrar por pantalla 
            // cuántos son pares.

            // int n, resultado, contador=0;
            // for (int x = 0; x < 20; x++)
            // {
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = int.Parse(Console.ReadLine());
            //     resultado = par(n);
            //     if(resultado==1){
            //         contador++;
            //     }
            // }    
            // Console.WriteLine("La cantidad de numeros pares es " + contador);


            // 3. Hacer una función llamada “primo” que reciba un número 
            // entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando 
            // se ingresa un número cero. Informar el promedio teniendo en cuenta 
            // sólo los números primos.

            // decimal n, resultado, contador=0, acumulador=0;
            // decimal promedio;
            // Console.WriteLine("Ingrese un numero: ");
            // n = int.Parse(Console.ReadLine());
            // while(n!=0){
            //     resultado=primo(n);
            //     if(resultado==1){
            //         acumulador+=n;
            //         contador++;
            //     }
            //     Console.WriteLine("Ingrese un numero: ");
            //     n = decimal.Parse(Console.ReadLine());
            // }
            // promedio=acumulador/contador;
            // Console.WriteLine("El promedio de los numeros primos es: " + promedio);


            // 4. Hacer una función de tipo void (porque no va a devolver nada) 
            // llamada “positivoNegativoCero” que reciba un número por valor 
            // y una  variable por referencia. Que analice el número y 
            // escriba variable recibida por referencia con:

            // a. 1 si el número es positivo.
            // b. -1 si el número es negativo.
            // c. 0 si el número es cero.
            // int n, r=0;
            // Console.WriteLine("Ingrese un nro: ");
            // n=int.Parse(Console.ReadLine());
            // positivoNegativoCero(ref n, ref r);
            // Console.WriteLine("El numero tiene la asignacion: " + r);
            

        }
        static int producto(int a, int b){
            int r;
            r=a*b;
            return r;
        }
        static int par(int a){
            int r;
            if(a%2==0){
                r=1;
            }
            else{
                r=0;
            }
            return r;
        }
        static int primo(decimal a){
            int r, contador=0;
            for(int x=1; x<=a; x++){
                if(a%x==0){
                    contador++;
                }
            }
            if(contador==2){
                r=1;
                return r;
            }
            else{
                r=0;
                return r;
            }
        }
        static void positivoNegativoCero(ref int a, ref int r){
            if(a>0){
                r=1;
            }
            else if(a<0){
                r=-1;
            }
            else{
                r=0;
            }
        }
    }
}
