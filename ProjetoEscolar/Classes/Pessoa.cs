namespace ProjetoEscolar
{
    public class Pessoa : IdCreater
    {
        private string nome { get; set; }
        private string cpf { get;  set; }
        private int idade { get; set; }
        private Genero genero { get; set; }
        private bool Excluido { get; set; }

        public Pessoa(string nome, string cpf, int idade, Genero genero, int id)
        {
            this.Id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
            this.genero = genero;
            
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.genero;
            retorno += "\tNome: " + this.nome;
            retorno += "\tCpf: " + this.cpf;
            retorno += "\tIdade: " + this.idade;
            retorno += "\tExcluido: " + this.Excluido;
            return retorno;

        }


        public string retornaNome()
        {
            return this.nome;
        }


        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
            //retorna se o aluno está excluido boolean
        }

        public void alunoExcluido()
        {
            this.Excluido = true;
            //implementada no repositório para excluir o aluno
        }
    }
}