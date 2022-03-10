using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEscolar.Interface;
namespace ProjetoEscolar
{
    class AlunoRepository : IRepositorio<Pessoa>
    {
        private List<Pessoa> listaPessoa = new List<Pessoa>();



        public void Exclua(int id)
        {
            listaPessoa[id].alunoExcluido();

        }

        public void Insere(Pessoa objeto)
        {
            listaPessoa.Add(objeto);
        }

        public void Atualiza(int id, Pessoa objeto)
        {
            listaPessoa[id] = objeto;
            
        }

        public List<Pessoa> List()
        {
            return listaPessoa;
        }

        public int ProximoId()
        {
            return listaPessoa.Count;
        }

        public Pessoa RetornaPorId(int id)
        {
            return listaPessoa[id];
        }



    }
}
