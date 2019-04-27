using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandsHomeWork22._04._2019
{
    public class AddMusicBand
    {
        public void AddBand(MusicBand musicBand, Song song)
        {
            Console.WriteLine("Введите название музыкальной группы: ");
                musicBand.Name = Console.ReadLine();
            Console.WriteLine("Введите название песни: ");
            song.Name = Console.ReadLine();
            Console.WriteLine("Введите слова песни: ");
            song.Words = Console.ReadLine();
            Console.WriteLine("Введите время звучания песен: ");
            song.DuringSounding = Console.ReadLine();
            Console.WriteLine("Введите рейтинг песни: ");
            song.Rating = int.Parse(Console.ReadLine());
            song.MusicBand = musicBand;
        }
    }
}
