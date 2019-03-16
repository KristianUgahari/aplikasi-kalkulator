using System;
namespace calculator
{
	class program
	{
		static void Main(string[] args)
		{
			Console.Title = " Aplikasi Calculator Sederhana oleh Ugahari ";
			Console.WriteLine("Pilih Menu Calculator : ");
			Console.WriteLine("1. Penjumlahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Pembagian");
			Console.WriteLine("4. Perkalian");
			
			Console.WriteLine();
			Console.Write("Pilih nomor menu yang Anda inginkan : ");
			int pilih = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			
			if (pilih > 4 || pilih < 1)
			{
				Console.WriteLine("Maaf, Menu tidak tersedia!");
				pesan();
			}
			else
			{
				Console.Write(" Masukan nilai a : ");
				int a = int.Parse(Console.ReadLine());
				
				Console.Write(" Masukan nilai b : ");
				int b = int.Parse(Console.ReadLine());
				
				if (pilih == 1)
				{
					Console.WriteLine(" Hasil Penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
				}
				else if (pilih == 2)
				{
					Console.WriteLine(" Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
				}
				else if (pilih == 3)
				{
					Console.WriteLine(" Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
				}
				else if (pilih == 4)
				{
					Console.WriteLine(" Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
				}
				pesan();
			}
		}
		static int penjumlahan(int a, int b)
		{
			return a + b;
		}
		static int pengurangan(int a, int b)
		{
			return a - b;
		}
		static float pembagian(float a, float b)
		{
			return a / b;
		}
		static int perkalian(int a, int b)
		{
			return a * b;
		}
		static void pesan()
		{
			Console.WriteLine();
			Console.WriteLine(" Tekan sembarang tombol untuk keluar ");
			Console.Readkey();
		}
	}
}