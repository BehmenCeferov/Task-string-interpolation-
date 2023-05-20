using Film_ve_Aktyor_OOP.Class;
using Film_ve_Aktyorlar_OOP.Class;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

FilmOperations filmOperations = new FilmOperations();
Film film1 = new Film { MovieName = "Avatar", DirectorName = "James Cameron", ImdbPoint = 8.1M, releaseDate = DateTime.Parse("December 16, 2022") };
Film film2 = new Film { MovieName = "Django Unchained", ImdbPoint = 8.4M, releaseDate = DateTime.Parse("December 25, 2012") };
filmOperations.Add(film1);
filmOperations.Add(film2);
AktyorOperations aktyorOperations = new AktyorOperations();
Aktyor aktyor1 = new Aktyor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 46 };
Aktyor aktyor2 = new Aktyor { FirstName = "Christoph", LastName = "Waltz", Age = 66 };
aktyorOperations.Add(aktyor1);
aktyorOperations.Add(aktyor2);
filmOperations.Delete(film1);

IEnumerable<Film> filmlər = filmOperations.GetAll();
IEnumerable<Aktyor> aktyorlar = aktyorOperations.GetAll();

Console.WriteLine("Filmlər:");
foreach (Film film in filmlər)
{
    Console.WriteLine($"Ad: {film.MovieName}, Rejissor: {film.DirectorName}, IMDB Xalı: {film.ImdbPoint}, {film.releaseDate}");
}

Console.WriteLine("Aktyorlar:");
foreach (Aktyor aktyor in aktyorlar)
{
    string fullName = aktyor.FullName();
    Console.WriteLine($"Tam Ad: {fullName}, Yaş: {aktyor.Age}");
}