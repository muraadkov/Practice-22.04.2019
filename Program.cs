using Practice22._04._2019;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBandsHomeWork22._04._2019
{
    class Program
    {
        static void Main(string[] args)
        {

                var musicBand = new MusicBand();
                var song = new Song();
                var addMusicBand = new AddMusicBand();
            while (true) {
            Console.WriteLine("1 - Добавить музыкальную группу. " +
                    "\n2 - Показать все музыкальные группы " +
                    "\n3 - Поиск по названию музыкальной группы" + 
                    "\n4 - Поиск по названию песни" + 
                    "\n5 - Сортировать по рейтингу песни");
                if (int.TryParse(Console.ReadLine(), out int number)) {
                    using (var context = new MBContext())
                    {
                        switch (number) {
                            case 1:
                                addMusicBand.AddBand(musicBand, song);
                                context.MusicBands.Add(musicBand);
                                context.Songs.Add(song);
                                context.SaveChanges();
                                break;

                            case 2:
                                {
                                    foreach (var mb in context.MusicBands.ToList())
                                    {
                                        Console.WriteLine($"Название музыкальной группы: {mb.Name}");
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Введите название группы, которую хотите найти: ");
                                    string nameOfSearchedMB = Console.ReadLine();
                                    var resultOfSearchedMB = context.MusicBands.ToList().Where(x => x.Name == nameOfSearchedMB);
                                    foreach (var s in resultOfSearchedMB)
                                    {
                                        Console.WriteLine($"Это та группа, которую вы хотели найти?\nНазвание: {s.Name}");
                                        foreach (var p in s.Songs) {
                                            Console.WriteLine($"Песни этой группы: {p.Name}");
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Введите название песни, которую хотите найти: ");
                                    string nameOfSearchedSong = Console.ReadLine();
                                    var resultOfSearchedSong = context.Songs.ToList().Where(x => x.Name == nameOfSearchedSong);
                                    foreach (var s in resultOfSearchedSong) {
                                        Console.WriteLine($"Это та песня, которую вы хотели найти? \nНазвание: {s.Name} \nРейтинг: {s.Rating} \nТекст песни: {s.Words} \nГруппа: {s.MusicBand.Name}");
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    int i = 1;
                                    Console.WriteLine("1 - Сортировать по убыванию " +
                                        "\n2 - Сортировать по возрастанию");
                                    int.TryParse(Console.ReadLine(), out int num);
                                    if (num == 1)
                                    {
                                        var sortedRongs = context.Songs.ToList().OrderBy(x => x.Rating);
                                        foreach (var s in sortedRongs)
                                        {
                                            Console.WriteLine($"{i++}. {s.Name} ");
                                        }
                                    }
                                    else if (num == 2)
                                    {
                                        var sortedSongs = context.Songs.ToList().OrderByDescending(x => x.Rating);

                                        foreach (var s in sortedSongs)
                                        {

                                            Console.WriteLine($"{i++}. {s.Name} ");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели не то число.");
                                    }
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
                Console.ReadLine();
            }
        }
    }
}
