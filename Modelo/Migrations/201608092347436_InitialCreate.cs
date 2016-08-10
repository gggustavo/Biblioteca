namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        IdAutor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdEditorial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAutor)
                .ForeignKey("dbo.Editorial", t => t.IdEditorial, cascadeDelete: true)
                .Index(t => t.IdEditorial);
            
            CreateTable(
                "dbo.Editorial",
                c => new
                    {
                        IdEditorial = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdEditorial);
            
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        IdLibro = c.Int(nullable: false, identity: true),
                        isbn = c.String(),
                        Titulo = c.String(),
                        Paginas = c.Int(nullable: false),
                        Precio = c.Int(nullable: false),
                        IdAutor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdLibro)
                .ForeignKey("dbo.Autor", t => t.IdAutor, cascadeDelete: true)
                .Index(t => t.IdAutor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libro", "IdAutor", "dbo.Autor");
            DropForeignKey("dbo.Autor", "IdEditorial", "dbo.Editorial");
            DropIndex("dbo.Libro", new[] { "IdAutor" });
            DropIndex("dbo.Autor", new[] { "IdEditorial" });
            DropTable("dbo.Libro");
            DropTable("dbo.Editorial");
            DropTable("dbo.Autor");
        }
    }
}
