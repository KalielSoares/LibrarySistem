namespace Biblioteca {
    public class User {

        public long CPF;
        public string Name;

        public List<Book> borrowed_books;


        public User(string name, long cpf) {
           Name = name;
            CPF = cpf;
            borrowed_books = new List<Book>();
        }

        public override string ToString() {
            return $"{Name}\n{CPF}\n";
        }
    }
}
