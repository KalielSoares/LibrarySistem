namespace Biblioteca {
    public class User {

        public string Name;
        public List<Livro> borrowed_books = new List<Livro>();


        public User(string name) {
           Name = name;
        }

        public void ExibirInformacoes() {
            Console.WriteLine($"Nome: {Name}\nLivros que pegou emprestado: {borrowed_books}");
        }
    }
}
