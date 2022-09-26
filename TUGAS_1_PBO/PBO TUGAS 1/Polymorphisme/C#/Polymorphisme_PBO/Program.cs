using System;

namespace Polymorphisme_PBO
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

            switch (menu)
            {
                case 1:
                    Console.WriteLine("\n(Persegi)");
                    Persegi persegi = new Persegi();
                    Console.Write("Masukkan Sisi : ");
                    persegi.sisi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Persegi : {0}", persegi.luas());
                    Console.WriteLine("Keliling Persegi : {0}", persegi.keliling());
                    break;
                case 2:
                    Console.WriteLine("\n(Persegi Panjang)");
                    PersegiPanjang persegipanjang = new PersegiPanjang();
                    Console.Write("Masukkan Panjang : ");
                    persegipanjang.panjang = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Lebar : ");
                    persegipanjang.lebar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Persegi Panjang : {0}", persegipanjang.luas());
                    Console.WriteLine("Keliling Persegi Panjang : {0}", persegipanjang.keliling());
                    break;
                case 3:
                    Console.WriteLine("\n(Segitiga)");
                    Segitiga segitiga = new Segitiga();
                    Console.Write("Masukkan Alas : ");
                    segitiga.alas = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Tinggi : ");
                    segitiga.tinggi = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Segitiga : {0}", segitiga.luas());
                    break;
                case 4:
                    Console.WriteLine("\n(Lingkaran)");
                    Lingkaran lingkaran = new Lingkaran();
                    Console.Write("Masukkan Jari-Jari : ");
                    lingkaran.jari = int.Parse(Console.ReadLine());
                    Console.WriteLine("Luas Lingkaran : {0}", lingkaran.luas());
                    Console.WriteLine("Keliling Lingkaran : {0}", lingkaran.keliling());
                    break;
            }
        }
        public abstract class BangunDatar
        {
            public double _hitung;
            public double Hitung
            {
                get { return _hitung; }
                set { _hitung = value; }
            }
            public abstract double luas();
            public abstract double keliling();
        }
        public class Persegi : BangunDatar
        {
            private double s;

            public double sisi
            {
                get { return s; }
                set { s = value; }
            }
            public Persegi()
            {
                this.sisi = sisi;
            }
            public override double luas()
            {
                return this.sisi * this.sisi;
            }
            public override double keliling()
            {
                return this.sisi * 4;
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
            public Segitiga()
            {
                this.alas = alas;
                this.tinggi = tinggi;
            }
            public override double luas()
            {
                return this.alas * this.tinggi / 2;
            }
            public override double keliling()
            {
                throw new NotImplementedException();
            }
        }
        public class PersegiPanjang : BangunDatar
        {
            private double p, l;
            public double panjang
            {
                get { return p; }
                set
                {
                    p = value;
                }
            }
            public double lebar
            {
                get { return l; }
                set
                {
                    l = value;
                }
            }
            public PersegiPanjang()
            {
                this.panjang = panjang;
                this.lebar = lebar;
            }
            public override double luas()
            {
                return this.panjang * this.lebar;
            }
            public override double keliling()
            {
                return 2 * (this.panjang * this.lebar);
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
            public Lingkaran()
            {
                this.jari = r;
            }
            public override double luas()
            {
                return (float)(Math.PI * r * r);
            }
            public override double keliling()
            {
                return (float)(2 * Math.PI * r);
            }
        }
    }
}