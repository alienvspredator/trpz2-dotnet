using System.Data.Entity;

namespace WpfApp4.Models
{
    /// <summary>
    /// Контекст БД библиотеки
    /// </summary>
    public class LibraryContext : DbContext
    {
        /// <summary>
        /// Инициализирует контекст БД из App.config
        /// </summary>
        public LibraryContext()
            : base("name=Library")
        {
        }

        /// <summary>
        /// Инициализирует подключение по строке подключения
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
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

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<HistoryItem> History { get; set; }
        public virtual DbSet<Charter> Charters { get; set; }
        public virtual DbSet<ReaderCard> ReaderCards { get; set; }
    }
}