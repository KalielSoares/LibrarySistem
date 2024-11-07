namespace Biblioteca {
    public class Book {

        public string Title;
        public string Autor;
        public int YearReleased;
        public bool available = true;

        public Book(string title, string autor, int yearReleased) {
            Title = title;
            Autor = autor;
            YearReleased = yearReleased;
        }


        public void info() {
            Console.WriteLine($"Title: {Title}\nAutor: {Autor}\nYear Released: {YearReleased}\nAvailable: {available}");
        }
    }
}
