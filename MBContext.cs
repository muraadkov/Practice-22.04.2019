namespace Practice22._04._2019
{
    using MusicBandsHomeWork22._04._2019;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MBContext : DbContext
    {
        // Контекст настроен для использования строки подключения "MBContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Practice22._04._2019.MBContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MBContext" 
        // в файле конфигурации приложения.
        public MBContext()
            : base("name=MBContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<MusicBand> MusicBands { get; set; }
        public DbSet<Song> Songs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}