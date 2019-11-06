using System;

namespace projeto3
{
    class Menu
    {

        public static void exibir()
        {

            Console.WriteLine("+------------------------+");
            Console.WriteLine("| 1. cadastrar usuario   ");
            Console.WriteLine("| 2. consultar usuario   ");
            Console.WriteLine("| 3. alterar   usuario   ");
            Console.WriteLine("| 4. SAIR                ");
            Console.WriteLine("+------------------------+");

        }
        public static int lerOpcao()
        {
            string opcao = Console.ReadLine();
            return Convert.ToInt32(opcao);
        }

        public static void exibirFormulario(int opcaoEscolhida)
        {

            switch (opcaoEscolhida)
            {
                case 1:
                    Console.WriteLine("+------------------------+");
                    Console.WriteLine("|                        ");
                    Console.WriteLine("|    digite o email      ");
                    string emailLido = Console.ReadLine();
                    Console.WriteLine("|    digite a senha      ");
                    string senhaLida = Console.ReadLine();
                    //Chamar logica de cadastro
                    Cadastrador cad = new Cadastrador();
                    Usuario u = new Usuario(emailLido, senhaLida);
                    int retorno = cad.cadastrarUsuario(u);
                    if (retorno != (int)Erros.sucesso)
                    {
                        Console.WriteLine("+------------------------+");
                        Console.WriteLine("| DADOS INVÁLIDOS!!!     ");
                        Console.WriteLine("+------------------------+");
                    }
                    else
                    {

                        Console.WriteLine("+------------------------+");
                        Console.WriteLine("| sucesso                ");
                        Console.WriteLine("+------------------------+");
                    }
            break;

            }





        }



    }



}









