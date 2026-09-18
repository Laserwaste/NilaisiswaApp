string namasiswa = "";
int nilaisiswa = 0;

Console.Write("aplikasi Nilai Siswa: ");

Console.Write("Masukkan Nama: ");
namasiswa = Console.ReadLine();

Console.Write("masukkan nilai: ");
nilaisiswa = int.Parse(Console.ReadLine());

if (nilaisiswa>= 75)
{
    Console.WriteLine("kamu lulus");
}

else
{
    Console.WriteLine("kamu tidak lulus");
}
