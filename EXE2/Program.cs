using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE2
{
    class Program
    {
        //Deklarasi array int dengan ukuran 32
        int[] MT = new int[32];

        //deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        int n;

        //mendapatkan jumlah elemen untuk disimpan apada array
        int i;

        //fungsi methode untuk menerima masukkan
        public void read()
        {
            //menerima angka untuk banyaknya data yang disimpan pada array
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 32)
                    break;
                else
                    Console.WriteLine(" \n Array dapat mempunyai maksimal 32 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");
            
            //pengguna memasukkan element pada array
            for(i = 0; i < 32; i++)
            {
                Console.Write("<" + i + ">");
                string s1 = Console.ReadLine();
                MT[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(MT[j]);
            }
            Console.WriteLine("");
        }
        public void SelectionSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int j = i-1; j < n; j++)
                {
                    if (MT[j] > MT[j + 1]) // jika elmen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = MT[j];
                        MT[j] = MT[j +1];
                        MT[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
