// See https://aka.ms/new-console-template for more information
Console.WriteLine("LIBRERIA BELLA.");

Console.WriteLine("  ");



List <Dvd> dvds = new List<Dvd>();
dvds.Add(new Dvd(12331, "Signore degli Anelli", 2000, "Fantasy", false, 5, "Peter Jackson", 120));
dvds.Add(new Dvd(1444, "Le Follie Dell'imperatore", 2000, "Commedia", false, 8, "Mark Dindal", 78));
dvds.Add(new Dvd(211111, "Il cavaliere oscuro", 2008, "Azione", false, 20, "Christopher Nolan", 152));

List <Libro> libros = new List<Libro>();
libros.Add(new Libro(9780261103665, "Il Silmarillion", 1977, "Fantasy", false, 5, "Tolkien", 1000));
libros.Add(new Libro(9788877827029, "Harry Potter", 1997, "Fantasy", false, 3, "J. K. Rowling", 1000));
libros.Add(new Libro(9780151660346, "1984", 1949, "Distopico", false, 3, "George Orwell", 1000));
