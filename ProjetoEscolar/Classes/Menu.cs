using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscolar
{

    public class Menu
    {
        static AlunoRepository repositorio = new AlunoRepository();

        
        public void mostrarMenu()
        {
            string obterUsuario = ObterOpcaoUsuario();

            while (obterUsuario.ToUpper() != "X")
            {
                switch (obterUsuario)
                {
                    case "1":
                        inserirAluno();
                        break;

                    case "2":
                        excluirAluno();
                        break;
                    case "3":
                        listarAluno();
                        break;
                    case "4":
                        atualizarAluno();
                        break;
                    case "5":
                        visualizarAlunoProps();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                obterUsuario = ObterOpcaoUsuario();
            }

        }

        private static void atualizarAluno()
        {


            listarAluno();
            Console.WriteLine("Informe o ID do aluno que deseja editar: ");
            int indiceAluno = int.Parse(Console.ReadLine());


            foreach (int i in Enum.GetValues(typeof(Genero)))

            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            try
            {

                Console.WriteLine("Digite o Nome do Aluno:");
                string entradaAluno = Console.ReadLine();

                Console.WriteLine("Digite o CPF do aluno:");
                string entradaCPF = Console.ReadLine();

                Console.WriteLine("Digite a idade do Aluno:");
                int entradaIdade = int.Parse(Console.ReadLine());



                if (entradaCPF.Length != 11)
                {
                    Console.WriteLine("O CPF precisa conter 11 dígitos");



                }
                else if (entradaAluno == "")
                {
                    Console.WriteLine("É necessário preencher o campo nome");
                }
                else
                {
                    Pessoa novoAluno = new Pessoa(id: indiceAluno,
                     genero: (Genero)entradaGenero,
                     nome: entradaAluno,
                     cpf: entradaCPF,
                     idade: entradaIdade);
                    Console.WriteLine(indiceAluno +""+ novoAluno);
                    repositorio.Atualiza(indiceAluno, novoAluno);
                    Console.WriteLine("Aluno atualizado com sucesso");
                }





            }
            catch (Exception)
            {

                Console.WriteLine("Erro ao atulizar");
                throw;
            }

        }


        private static void excluirAluno()
        {
            Console.WriteLine("Digite o ID do Aluno que deseja excluir: ");
            int indiceAluno = int.Parse(Console.ReadLine());
            repositorio.Exclua(indiceAluno);
        }


        private static void listarAluno()
        {
            Console.WriteLine("Listar Alunos(a): ");
            var listar = repositorio.List();

            if (listar.Count == 0)
            {
                Console.WriteLine("Ainda não tem nenhum Aluno cadastrado, volte ao Menu e cadastre um aluno.");
            }

            foreach (var aluno in listar)
            {
                var excluido = aluno.retornaExcluido();
                if (!excluido)
                {
                    Console.WriteLine("#ID {0}: - {1}", aluno.retornaId(), aluno.retornaNome());
                }
            }

        }

        private static void inserirAluno()
        {

            Console.WriteLine("Inserir novo Aluno");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());




            try {

                Console.WriteLine("Digite o Nome do Aluno:");
                string entradaAluno = Console.ReadLine();

                Console.WriteLine("Digite o CPF do aluno:");
                string entradaCPF = Console.ReadLine();

                Console.WriteLine("Digite a idade do Aluno:");
                int entradaIdade = int.Parse(Console.ReadLine());



                if (entradaCPF.Length != 11)
                {
                    Console.WriteLine("O CPF precisa conter 11 dígitos");



                }
                else if (entradaAluno == "")
                {
                    Console.WriteLine("É necessário preencher o campo nome");
                }
                else
                {
                    Pessoa novoAluno = new Pessoa(id: repositorio.ProximoId(),
                     genero: (Genero)entradaGenero,
                     nome: entradaAluno,
                     cpf: entradaCPF,
                     idade: entradaIdade);
                    repositorio.Insere(novoAluno);
                    Console.WriteLine("Aluno cadastrado com sucesso");
                }





            }
            catch (Exception)
            {

                Console.WriteLine("Erro ao cadastrar");
                throw;
            }





        }




        private static void visualizarAlunoProps()
        {
            Console.WriteLine("Digite o ID do Aluno: ");
            int indiceAluno = int.Parse(Console.ReadLine());

            var Aluno = repositorio.RetornaPorId(indiceAluno);
            Console.WriteLine(Aluno);
        }



        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine(" Cadastro de alunos a seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir um novo Aluno");
            Console.WriteLine("2 - Excluir Aluno");
            Console.WriteLine("3 - Listar Aluno");
            Console.WriteLine("4 - Atualizar Aluno");
            Console.WriteLine("5 - Listar Aluno com todos os dados");
            Console.WriteLine("6 - limpar Tela");
            Console.WriteLine("X - Sair");

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }


    }

}




