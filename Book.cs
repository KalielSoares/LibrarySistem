namespace Biblioteca {
    public class Book {

        public string Title;
        public string Autor;
        public int YearReleased;
        public bool Available = false;

        public Book(string title, string autor, int yearReleased, bool available) {
            Title = title;
            Autor = autor;
            YearReleased = yearReleased;
            Available = available;
        }


        public override string ToString() {
            return $"Title: {Title}\nAutor: {Autor}\nYear Released: {YearReleased}\n";
        }

    }
}
