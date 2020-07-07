using System.Collections.Generic;

namespace Wpp_Console
{
    public interface IAgenda
    {
         void Cadastrar(Contato cont);
         
         void Excluir(Contato cont);

         List<Contato> Listar();
    }
}