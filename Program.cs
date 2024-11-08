
namespace Biblioteca {
    class Program {
        static void Main(string[] args) {

            Library library = new Library();


            int resposta;



            Console.WriteLine("Biblioteca NC");
            Console.WriteLine("O que vamos fazer hoje?\n1- Cadastrar uma pessoa\n2 - Cadastrar um livro\n3 - Pegar um livro emprestado\n4 - ver pessoas cadastradas\n5 - Sair\n");
            resposta = int.Parse(Console.ReadLine());
            do {




                switch (resposta) {

                    //Cadastro de Usuario
                    case 1:
                        string register;
                        do {

                            Console.WriteLine("\nDigite os dados do novo usuário: ");
                            Console.WriteLine("\nDigite o nome: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("\nDigite o cpf: ");
                            long cpf = long.Parse(Console.ReadLine());

                            library.createUser(new User(nome, cpf));

                            Console.WriteLine("Deseja Continuar?(s/n) ");
                            register = Console.ReadLine();
                        } while (register == "s");
                        break;
                    //Cadastro de Livro
                    case 2:
                        do {
                            Console.WriteLine("Vamos cadastrar um livro:");
                            Console.WriteLine("Qual o nome do livro?");
                            string title = Console.ReadLine();
                            Console.WriteLine("Qual o nome do autor desse livro?");
                            string autor = Console.ReadLine();
                            Console.WriteLine("Qual o Ano de lançamento desse livro?");
                            int yearReleased = int.Parse(Console.ReadLine());
                            bool avaliable;

                            library.addBook(new Book(title, autor, yearReleased, avaliable = true));

                            Console.WriteLine("Deseja Continuar?(s/n) ");
                            register = Console.ReadLine();

                        } while (register == "s");
                        break;
                    //Pegar Livro Emprestado
                    case 3:



                        break;
                    case 4:
                        foreach (var pessoa in library.Users) {
                            Console.WriteLine(pessoa);
                        }
                        break;

                }


                Console.WriteLine("O que vamos fazer hoje?\n1- Cadastrar uma pessoa\n2 - Cadastrar um livro\n3 - Pegar um livro emprestado\n4 - ver pessoas cadastradas\n5 - Sair\n");
                resposta = int.Parse(Console.ReadLine());


            } while (resposta != 5);
        }
    }


}



