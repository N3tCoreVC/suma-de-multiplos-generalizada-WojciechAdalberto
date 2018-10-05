using System;
using System.Collections.Generic;

namespace multgensum
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> Multiplos = new List<int>();
            int numero;
            Console.WriteLine("Capture los numeros que desee para verificar si son multiplos ");
            while( Int32.TryParse(Console.ReadLine(), out numero) )
            {
                if ( !Multiplos.Contains(numero) )
                { 
                    Multiplos.Add(numero);
                }
            }            
            Console.WriteLine("El numero hasta que debe verificar");
            if ( Int32.TryParse(Console.ReadLine(), out numero) ){
                int suma = 0;
                numero++;
                for ( int i = 1 ; i < numero ; i++ ){
                    for ( int j= 0 ; j < Multiplos.Count ; j++ )
                    {
                        if (i%Multiplos[j]==0)
                        {
                            suma = suma + i;
                            break;
                        }
                    }
                }
                Console.WriteLine("Los numeros capturados fueron :");
                for ( int i = 0 ; i < Multiplos.Count ; i++ )
                {
                    Console.Write(" " + Multiplos[i]);
                }
                Console.WriteLine();
                numero--;
                Console.WriteLine("La suma hasta " + numero + " fue de "+suma);
            } else{
                Console.WriteLine("No es un numero");
            }
        }
    }
}
