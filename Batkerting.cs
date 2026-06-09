public class Batkerting
{
    public Kondisi ApakahPlayerMenang
        (Player player, Player komputer)
    {
        if (player.tangan == komputer.tangan)
        {
            return Kondisi.Draw;
        }

        if (player.tangan == Tangan.Batu)
        {
            if (komputer.tangan == Tangan.Kertas)
            {
                return Kondisi.Kalah;
            }
            return Kondisi.Menang;
        }
        else if (player.tangan == Tangan.Kertas)
        {
            if (komputer.tangan == Tangan.Gunting)
            {
                return Kondisi.Kalah;
            }
            return Kondisi.Menang;
        }
        if (player.tangan == Tangan.Gunting)
        {
            if (komputer.tangan == Tangan.Batu)
            {
                return Kondisi.Kalah;
            }
            return Kondisi.Menang;
        }
        
        return Kondisi.Draw;
    }
}