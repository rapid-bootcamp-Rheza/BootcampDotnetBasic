using Logic2;
public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine("Masukkan Angka :");
        
        string? input = Console.ReadLine();
        int n = input == null ? 0 : int.Parse(input);

        Console.WriteLine("Soal 1: ");
        Logic2Soal1.CetakData(n);

        Console.WriteLine("soal 2: ");
        Logic2Soal2.Cetak2(n);

        Console.WriteLine("soal 3: ");
        Logic2Soal3.Cetak3(n);

        Console.WriteLine("soal 4: ");
        Logic2Soal4.Cetak4(n);

        Console.WriteLine("soal 5: ");
        Logic2Soal5.Cetak5(n);

        Console.WriteLine("soal 6: ");
        Logic2Soal6.Cetak6(n);

        Console.WriteLine("soal 9: ");
        Logic2Soal9.Cetak9(n);
    }
}
