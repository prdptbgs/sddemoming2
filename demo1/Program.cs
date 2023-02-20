//1. buat program pointer dengan inputan maksimal 5 inputan !
using System;
namespace demo1
{
     unsafe
    class Program
    {
        static void Main(string[]args)
        {
            int [] arr = new int [5];
            fixed(int *ptr = &arr[0])
            {
                for(int i = 0;i < 5;i++)
                {
                    Console.Write("masukkan input : ");
                    *ptr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("nilai {0}",*ptr);
                    Console.WriteLine("addres = {0}", (int)(ptr + i));
                }
            }

        } 
    }
}