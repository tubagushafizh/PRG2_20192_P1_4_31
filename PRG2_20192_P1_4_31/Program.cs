using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_4_31
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("MENU SEGITIGA SIKU - SIKU");
                Console.WriteLine("a. Hitung Luas");
                Console.WriteLine("b. Hitung Hipotunesa");
                Console.WriteLine("c. Hitung Keliling");
                Console.WriteLine("d. Keluar\n");
                Console.Write("Menu Pilihan : ");
                char menu;
                menu = Convert.ToChar(Console.ReadLine());
                switch (menu)
                {
                    case 'a':
                        Console.Clear();
                        Console.WriteLine("LUAS SEGITIGA");
                        Console.Write("Masukkan Alas : ");
                        Double alas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi : ");
                        Double tinggi = Convert.ToDouble(Console.ReadLine());
                        Double luas = alas * tinggi / 2;
                        Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, luas);
                        break;


                    case 'b':
                        Console.Clear();
                        Console.WriteLine("HIPOTENUSA SEGITIGA");
                        Console.Write("Masukkan Alas : ");
                        alas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi : ");
                        tinggi = Convert.ToDouble(Console.ReadLine());
                        Double hipotenusa = Convert.ToInt16(Math.Sqrt((alas * alas) + (tinggi * tinggi)));
                        Console.WriteLine("Hipotenusa dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, hipotenusa);
                        break;

                    case 'c':
                        Console.Clear();
                        Console.WriteLine("HIPOTENUSA SEGITIGA");
                        Console.Write("Masukkan Alas : ");
                        alas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi : ");
                        tinggi = Convert.ToDouble(Console.ReadLine());
                        hipotenusa = Convert.ToDouble(Math.Sqrt((alas * alas) + (tinggi * tinggi)));
                        Double keliling = alas + tinggi + hipotenusa;
                        Console.WriteLine("Keliling dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, keliling);
                        break;

                    case 'd':
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Ulangi [y/t]");
            } while (Console.ReadLine() == "y");
        }
    }
}
