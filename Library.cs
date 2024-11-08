namespace Biblioteca {
    public class Library {

        //Usuarios
        public List<User> Users;
        //Emprestimo
        public Dictionary<User, Book> Borrow;
        //Catalogo
        public List<Book> Catalog;

        public Library() {
            Catalog = new List<Book>();
            Users = new List<User>();
        }

        public void addBook(Book book) {
            Catalog.Add(book);
            Console.WriteLine($"Livro:\n{book} \nadicionado ao Catalogo.");
        }

        public void createUser(User user) {
            Users.Add(user);
            Console.WriteLine($"Usuario:\n{user} cadastrado com sucesso.");
        }




    }




}

