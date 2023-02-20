/*
2. buat Program dengan menu stack dengan ketentuan sebagai berikut
   -  jumlah stack maksimal 10, bisa melakukan operasi push, pop dan peek ! 
   - Bisa menghitung jumlah elemen dalam stack !
   -  Buat contoh untuk fungsi enumerator dalam stack !
   -  mengosongkan isi dari stack dan tunjukan stack dalam kondisi kosong !
   - Menu Terdiri dari dari menu PUSH, POP, PEEK, Enumerator, dan Clear !
*/
using System;
using System.Collections.Generic;

namespace CobaStack
{
    class Program
    {
        public static void Main()
        {
            Stack<int> Mystack = new Stack<int>();

            int oubox = 0;
            while(oubox != 6){
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1. PUSH ");
                Console.WriteLine("2. POP ");
                Console.WriteLine("3. PEEK ");
                Console.WriteLine("4. ENUMERATE ");
                Console.WriteLine("5. CLEAR ");
                Console.WriteLine("6. LOG OUT ");
                Console.WriteLine("---------------------------");
                Console.Write("Masukkan Pilihan = ");
                oubox = Convert.ToInt32(Console.ReadLine());

                switch(oubox){
                    case 1:
                        Console.Write("Masukkan Batas Jumlah Stack (Maks 10) = ");
                        int batas = Convert.ToInt32(Console.ReadLine());
                        if(Mystack.Count() == 0 || (Mystack.Count() + batas) <= 10){
                            if(batas <= 10){
                                for (int i = 0; i < batas; i++){
                                    Console.Write("Masukkan Element = ");
                                    int input = Convert.ToInt32(Console.ReadLine());
                                    Mystack.Push(input);
                                }
                            }
                        } else{
                            Console.WriteLine("Stack Sudah Penuh");
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        if(Mystack.Count() == 0 ){
                            Console.WriteLine("Stack Masih Kosong!! Silahkan Lakukan Push Operation");
                        } else{
                            int poped = Mystack.Pop();
                            Console.WriteLine("Element Yang Di-Pop = {0}", poped);
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        if(Mystack.Count() == 0 ){
                            Console.WriteLine("Stack Masih Kosong!! Silahkan Lakukan Push Operation");
                        } else {
                            int teratas = Mystack.Peek();
                            Console.WriteLine("Element Teratas Stack = {0}", teratas);
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        if(Mystack.Count() == 0 ){
                            Console.WriteLine("Stack Masih Kosong!! Silahkan Lakukan Push Operation");
                        } else {
                            int jumlah = Mystack.Count();
                            Console.WriteLine("Jumlah Element Dalam Stack = {0}", jumlah);
                            Console.Write("Element Dari Stack = ");
                            foreach(object isi in Mystack){
                                Console.Write(isi + " ");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 5:
                        if (Mystack.Count() == 0) {
                            Console.WriteLine("Stack Masih Kosong!! Silahkan Lakukan Push");
                        }else{
                            Mystack.Clear();
                            Console.WriteLine("Isi Dari Stack Sudah Dihapus");
                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Angka Yang Dimasukkan Tidak Valid");
                        break;
                }
            }
        }
    }
}