namespace Biblioteca {
    public class User {

        public long CPF;
        public string Name;

        public List<Livro> borrowed_books = new List<Livro>();


        public User(string name, long cpf) {
           Name = name;
            CPF = cpf;
        }

        public void ExibirInformacoes() {
            Console.WriteLine($"ID:{CPF} Nome: {Name}\n");
        }
    }
}
