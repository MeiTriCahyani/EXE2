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

        //number of comparasion
        private int cmp_count = 0; 

        //number of data movement
        private int mov_count = 0;

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
            for (int MC = 0; MC < n; MC++)
            {
                Console.WriteLine(MT[MC]);
            }
            Console.WriteLine("");
        }
        public void SelectionSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                //pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int MC = i-1; MC < n; MC++)
                {
                    if (MT[MC] > MT[MC + 1]) // jika elmen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = MT[MC];
                        MT[MC] = MT[MC +1];
                        MT[MC + 1] = temp;
                    }
                }
            }
        }
        //memindahkan elemen x dengan elemen y
        void swap (int x, int y)
        {
            int temp;
            temp = MT[x];
            MT[x] = MT[y];
            MT[y] = temp;
        }

        //membuat merge sort array
        void mergesort(int low, int hight)
        {
            int k, i, MC, mid;
            if (low >= hight) ;
            return;

            i = low;
            MC = mid + 1;
            k = low;
            mid = (low + hight) / 2;


        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine(" Menu Option ");
                Console.WriteLine("===================");
                Console.WriteLine("1. SelectionSort");
                Console.WriteLine("2. MergeSort");
                Console.WriteLine("3. Exit");
                Console.Write(" Enter your choice (1,2,3) :");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(".................");
                        Console.WriteLine(" Selection Short");
                        Console.WriteLine(".................");
                        mylist.read();
                        mylist.display();
                        mylist.SelectionSortArray();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(".................");
                        Console.WriteLine("MergeSort Search");
                        Console.WriteLine(".................");
                        mylist.read();
                        mylist.display();
                        mylist.mergesort();
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("eror");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\npress return to exit.");
                Console.ReadLine();

            } while (pilihanmenu != 3);
        }
    }
}
