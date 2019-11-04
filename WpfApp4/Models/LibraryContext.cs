﻿using System.Data.Entity;

namespace WpfApp4.Models
{
    public class LibraryContext : DbContext
    {
        // Контекст настроен для использования строки подключения "Library" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WpfApp4.Models.Library" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Library" 
        // в файле конфигурации приложения.
        public LibraryContext()
            : base("name=Library")
        {
        }

        public LibraryContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Authors");
            });

            modelBuilder.Entity<Reader>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Readers");
            });

            modelBuilder.Entity<ReaderCard>()
                .HasRequired(m => m.Owner)
                .WithRequiredDependent(m => m.Card);
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<HistoryItem> History { get; set; }
        public virtual DbSet<Charter> Charters { get; set; }
        public virtual DbSet<ReaderCard> ReaderCards { get; set; }
    }

    // public class MyEntity
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    // }
}