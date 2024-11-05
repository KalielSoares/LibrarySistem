namespace Biblioteca {
    public class Livro {

        public string Title;
        public string Autor;
        public int YearReleased;
        public bool available = true;
        public string borrower;

        public void lend() {
            available = false;
        }

        public void returnBook() {
            available = true;
        }

        public void info() {
            Console.WriteLine($"Title: {Title}\nAutor: {Autor}\nYear Released: {YearReleased}\nAvailable: {available}");
        }
    }
}
