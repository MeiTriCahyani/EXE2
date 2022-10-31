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
        }

        static void Main(string[] args)
        {
        }
    }
}
