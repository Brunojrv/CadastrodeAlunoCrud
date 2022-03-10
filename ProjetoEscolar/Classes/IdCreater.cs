using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscolar
{
   public abstract class IdCreater
    {
        public int Id { get;  protected set; }
    }
    // criação da classe abstrata para que ela não seja instanciada e apenas implementada. O ID fica protegido para que seja possível apenas a inclusão do id e nunca a alteração do número do id.
}
