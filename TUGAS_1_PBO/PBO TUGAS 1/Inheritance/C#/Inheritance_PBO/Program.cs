using System;

namespace Inheritance_PBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Bangun Datar)");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Lingkaran");
            Console.Write("Pilih Menu : ");
            int menu = int.Parse(Console.ReadLine());

            BangunDatar bangunDatar = new BangunDatar();
            bangunDatar.luas();
            bangunDatar.keliling();

            switch (menu)
            {
                case 1:
                    Console.WriteLine("(Persegi)");
                    Persegi persegi = new Persegi();
                    Console.Write("Masukkan Sisi : ");
                    int sisi = int.Parse(Console.ReadLine());
                    persegi.sisi = sisi;
                    persegi.luas();
                    persegi.keliling();
                    break;
                case 2:
                    Console.WriteLine("(Persegi Panjang)");
                    PersegiPanjang persegipanjang = new PersegiPanjang();
                    Console.Write("Masukkan Panjang : ");
                    int panjang = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Lebar : ");
                    int lebar = int.Parse(Console.ReadLine());
                    persegipanjang.panjang = panjang;
                    persegipanjang.lebar = lebar;
                    persegipanjang.luas();
                    persegipanjang.keliling();
                    break;
                case 3:
                    Console.WriteLine("(Segitiga)");
                    Segitiga segitiga = new Segitiga();
                    Console.Write("Masukkan Alas : ");
                    int alas = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Tinggi : ");
                    int tinggi = int.Parse(Console.ReadLine());
                    segitiga.alas = alas;
                    segitiga.tinggi = tinggi;
                    segitiga.luas();
                    segitiga.keliling();
                    break;
                case 4:
                    Console.WriteLine("(Lingkaran)");
                    Lingkaran lingkaran = new Lingkaran();
                    Console.Write("Masukkan Jari-Jari : ");
                    int jari = int.Parse(Console.ReadLine());
                    lingkaran.jari = jari;
                    lingkaran.luas();
                    lingkaran.keliling();
                    break;
            }
        }

        public class BangunDatar
        {
            internal float luas()
            {
                Console.WriteLine("\nMenghitung luas bangun datar");
                return 0;
            }

            internal float keliling()
            {
                Console.WriteLine("Menghitung keliling bangun datar");
                return 0;
            }
        }

        public class Persegi : BangunDatar
        {
            private double s;
            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
        }

        public class PersegiPanjang : BangunDatar
        {
            private float p, l;

            public float panjang
            {
                get { return p; }
                set
                {
                    p = value;
                }
            }

            public float lebar
            {
                get { return l; }
                set
                {
                    l = value;
                }
            }
        }

        public class Segitiga : BangunDatar
        {
            private float a, t;

            public float alas
            {
                get { return a; }
                set
                {
                    a = value;
                }
            }

            public float tinggi
            {
                get { return t; }
                set
                {
                    t = value;
                }
            }
        }
        public class Lingkaran : BangunDatar
        {
            private double r;

            public double jari
            {
                get { return r; }
                set
                {
                    r = value;
                }
            }
        }
    }
}