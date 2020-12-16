using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //mencetak tulisan di console
            //Console.Write("Hello World!");
            //Console.WriteLine("hellod world 2");
            //Console.Write("hello world 3");
            String nama_depan = "Fermi";
            String nama_tengah = "naufal";

            Console.WriteLine(nama_depan);
            Console.WriteLine(nama_tengah);

            //penggabungan string
            string kata1 = "fermi";
            string kata2 = "naufal";

            Console.WriteLine(kata1 + " " + kata2);

            //aritmatika (+,-,*,/)
            int angka1 = 10;
            int angka2 = 2;

            Console.WriteLine(angka1 + angka2); //tanda + bisa diganti dengan operator aritmatika

            //constanta (nilai tidak berubah)
            const int a = 20;
            Console.WriteLine(a);

            //tipe data
            float angka3 = 5;
            float angka4 = 2;
            float hasil = angka3 / angka4;

            Console.WriteLine(hasil);

            bool woman = true;
            if (woman)
            {
                Console.WriteLine("gender saya wanita");
            }
            else
            {
                Console.WriteLine("gender saya pria");
            }

            //ternary
            string username = "user";
            /*
            if(username == "user")
            {
                Console.WriteLine("selamat datang " + username);
            } 
            else
            {
                Console.WriteLine("username anda salah");
            }
            */

            Console.WriteLine(username == "users" ? "selamat datang " + username : "username anda salah");

            //switch
            int angka = 2;
            switch (angka)
            {
                case 1:
                    Console.WriteLine("angka 1");
                    break;
                case 2:
                    Console.WriteLine("angka 2");
                    break;
                default:
                    Console.WriteLine("angka tidak sama");
                    break;
            }

            //while
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("hallo");
                i++;
            }

            //for
            string text = "halo";
            for (int sa = 0; sa < 5; sa++)
            {
                Console.WriteLine(text + (sa + 1));
            }

            //do while
            int ulang = 1;
            do
            {
                Console.WriteLine("ulang " + ulang);
                ulang++;
            } while (ulang < 5);

            //array
            string[,,] daftarnama = { { { "mami", "kemi" }, { "data1", "data2" } }, { { "andri", "komen" }, { "asti", "rendi" } }, { { "andri", "komen" }, { "asti", "rendi" } } };
            /*
            for(int s = 0; s < daftarnama.Length; s++)
            {
                Console.WriteLine(daftarnama[s]);
            }
            */
            //Console.WriteLine(daftarnama[1,1]);

            //length = untuk mengetahui panjang array
            Console.WriteLine(daftarnama.Length);

            //rank = untuk mengetahui dimensi array
            Console.WriteLine(daftarnama.Rank);

            //getlength -> 0 untuk mengetahui jumlah array, 1 untuk mengetahui jumlah elemen array
            Console.WriteLine(daftarnama.GetLength(0));
            Console.WriteLine(daftarnama.GetLength(1));

            //foreach
            foreach (string data in daftarnama)
            {
                Console.WriteLine(data);
            }

            //list
            List<string> kota = new List<string>(new string[2]{"surabaya","jakarta"});
            kota.Add("bandung");

            Console.WriteLine(kota[2]);

            //input console
            /*
            Console.Write("Masukan nama anda : ");
            string nama = Console.ReadLine();

            Console.Write("Masukan password anda : ");
            int psswd = int.Parse(Console.ReadLine());

            Console.WriteLine("selamat datang " + nama + " password anda " + psswd);
            */

        //label & goto
        /*
        username:
            Console.Write("Masukan username : ");
            string cek = Console.ReadLine();
            if(cek == "ani")
            {
                Console.WriteLine("Selamat datang " + cek);
            }
            else
            {
                Console.WriteLine("username anda salah");
                goto username; //kembali menjalankan label username dari awal
            }

        password:
            Console.Write("Masukan password : ");
            string psswd = Console.ReadLine();
            if (psswd == "user")
            {
                Console.WriteLine("Selamat datang");
            }
            else
            {
                Console.WriteLine("password anda anda salah");
                goto password; //kembali menjalankan label password dari awal
            }
        */

            //break & continue
            //break = memberhentikan program
            //continue = melanjutkan program selanjutnya

            angka = 0;
            while(angka <= 10)
            {
                Console.WriteLine(angka);
                angka++;
                if (angka == 5)
                {
                    continue;
                }
                else if(angka >= 8)
                {
                    break;
                }
                
            }

            //pemanggilan fungsi
            /*
            Program user = new Program();

            Console.Write("Masukan nama anda : ");
            string name = Console.ReadLine();

            user.user(name);
            Console.WriteLine("umur anda " + user.umur(7) + " tahun");
            */


            /* operator
             * OR || = salah satu bernilai benar maka true
             * and && = salah satu bernilai salah maka false
             * XOR ^ = keduanya bernilai benar/salah maka false
             * Not ! = membalikan nilai sebenarnya, misal !true = false
             */

            bool kond1 = true;
            bool kond2 = true;

            if(kond1 ^ kond2)
            {
                Console.WriteLine("kondisi benar");
            }
            else
            {
                Console.WriteLine("kondisi salah");
            }

            Console.ReadKey();
        }

        //fungsi
        void user(string name)
        {
            Console.WriteLine("hallo " + name);
        }

        int umur(int umur)
        {
            return umur;
        }
    }
}
