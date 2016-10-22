# Biblioteca

This app called Library is very simple

* EntityFramework use Code Fist
* MVC (Model- View -Controller) introducction
* Simple Injector
* Report RDLC
* Stored Procedure
	CREATE PROCEDURE [dbo].[GetLibroById]
		@idLibro int
	AS
		SELECT  isbn,
				Titulo,
				Precio
		FROM Libro
		WHERE IdLibro = @idLibro


Steps

Run the **Enable-Migrations** command in Package Manager Console

Code First Migrations has two primary commands that you are going to become familiar with.

**Add-Migration** will scaffold the next migration based on changes you have made to your model since the last migration was created

**Update-Database** will apply any pending migrations to the database

For more information about EntityFramework visit: https://msdn.microsoft.com/en-us/data/ee712907.aspx

