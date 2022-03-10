using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscolar.Interface
{ // Criação da interface para encapsulamento do código, a interface foi herdada na classe alunorepository respeitando o padrão da implementação ("todos os metodos da inteface implementados na classe aluno repository")
    public interface IRepositorio<T>
    {
        List<T> List();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Atualiza(int id, T entidade);

        void Exclua(int id);

       
        int ProximoId();
    }
}
