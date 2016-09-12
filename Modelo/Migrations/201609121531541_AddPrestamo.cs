namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrestamo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prestamo",
                c => new
                    {
                        IdPrestamo = c.Int(nullable: false),
                        IdLibro = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdPrestamo)
                .ForeignKey("dbo.Libro", t => t.IdPrestamo)
                .Index(t => t.IdPrestamo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamo", "IdPrestamo", "dbo.Libro");
            DropIndex("dbo.Prestamo", new[] { "IdPrestamo" });
            DropTable("dbo.Prestamo");
        }
    }
}
