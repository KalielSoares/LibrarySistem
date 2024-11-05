using System.Xml.Linq;

namespace Biblioteca {
    class Program {
        static void Main(string[] args) {

            List<User> Pessoas = new List<User>();


            /*
            string register;

            do {
                Console.WriteLine("\nDigite os dados do novo usuário: ");
                Console.WriteLine("\nDigite o nome: ");
                string nome = Console.ReadLine();

                Pessoas.Add(new User(nome));

                Console.WriteLine("Deseja Continuar?(s/n) ");
                register = Console.ReadLine();
            } while (register == "s");


            foreach (var pessoa in Pessoas)
            {
                pessoa.ExibirInformacoes();
            }

            */




             Livro libre = new Livro();


            Console.WriteLine("Biblioteca NC");
            Console.WriteLine("Vamos cadastrar um livro:");
            Console.WriteLine("Qual o nome do livro?");
            libre.Title = Console.ReadLine();
            Console.WriteLine("Qual o nome do autor desse livro?");
            libre.Autor = Console.ReadLine();
            Console.WriteLine("Qual o Ano de lançamento desse livro?");
            libre.YearReleased = int.Parse(Console.ReadLine());

            libre.info();

            Console.WriteLine();
            
        }
    }
}