namespace ConnectionsDz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompanyContext : DbContext
    {
        // Контекст настроен для использования строки подключения "CompanyContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ConnectionsDz.CompanyContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "CompanyContext" 
        // в файле конфигурации приложения.
        public CompanyContext()
            : base("name=CompanyContext")
        {
        }

        public DbSet<Employer> Employers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}