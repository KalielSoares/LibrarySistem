using System.Xml.Linq;

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


        public Livro(string title, string autor, int yearReleased) {
            Title = title;
            Autor = autor;
            YearReleased = yearReleased;
        }


        public void info() {
            Console.WriteLine($"Title: {Title}\nAutor: {Autor}\nYear Released: {YearReleased}\nAvailable: {available}");
        }
    }
}
