Console.WriteLine("Batu Kertas Gunting v1.0");

Player player = new();
player.nama = "Anda";
Player komputer = new();
komputer.nama = "Komputer";

while (true) {
    Console.WriteLine("Pilih salah satu:");
    Console.WriteLine("1. Batu");
    Console.WriteLine("2. Kertas");
    Console.WriteLine("3. Gunting");    

    string text = Console.ReadLine();
    int input = int.Parse(text[0].ToString());
    int inputKomputer = Random.Shared.Next(0, 3);

    player.tangan = (Tangan)(input - 1);
    komputer.tangan = (Tangan)inputKomputer;

    Batkerting bkg = new();
    Kondisi kondisi = bkg.ApakahPlayerMenang(player, komputer);

    Console.WriteLine("Komputer mengeluarkan " + komputer.tangan.ToString());
    Console.WriteLine("Anda " + kondisi.ToString());
}

Console.ReadKey();