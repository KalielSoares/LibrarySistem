namespace Biblioteca {
    public class Library {

        //Usuarios
        public List<User> Users ;
        //Emprestimo
        public Dictionary<User, Book> Borrow;
        //Catalogo
        public List<Book> Catalog;

        public Library() {
            Catalog = new List<Book>();
            Users = new List<User>();
            Borrow = new Dictionary<User, Book>();
        }

        public string lean() {
            
            
            foreach (var item in Users)
            {
                
            }
        }

    }
}
