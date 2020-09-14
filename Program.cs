
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina_Array{
    class Program{
        static void Main(string[] args){
            /* Generazione di un Array casuale di 1000 elementi e stamparlo ordinato */
            int[] array = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++) array[i] = rnd.Next(-100, 101);
            Console.WriteLine("Array non ordinato:");
            for (int i = 0; i < 100; i++) Console.Write(array[i] + "; ");
            selection_sort(ref array);
            Console.WriteLine("\n" + "Array ordinato:");
            for (int i = 0; i < 100; i++) Console.Write(array[i] + "; ");
            Console.WriteLine("\n" + "Premi un tasto per terminare il programma");
            Console.ReadKey();
        }
        static void selection_sort(ref int[] array){
            for (int min = 0, i = 0; i < 1000 - 1; i++, min = i){
                for (int n = i + 1; n < 1000; n++)
                    if (array[n] < array[min]) min = n;
                swap(ref array[min], ref array[i]);
            }
        }
        static void swap(ref int x, ref int y){
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
