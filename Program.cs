using System;

namespace Wpp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           Agenda agenda = new Agenda();
           
           Contato c1 = new Contato("Henrique", "(11) 99999-9999");
           Contato c2 = new Contato("Leandro", "(11) 99999-9999");
           Contato c3 = new Contato("Franco", "(11) 99999-9999");

            agenda.Cadastrar(c1);
            agenda.Cadastrar(c2);
            agenda.Cadastrar(c3);

            agenda.Excluir(c2);

           foreach ( Contato c in agenda.Listar())
           {
               Console.WriteLine($"nome: {c.Nome} - Tel: {c.Telefone}");
           }
           Mensagem msg = new Mensagem();
           msg.Destinatario = c3;
           msg.Texto = "Olá " + msg.Destinatario.Nome + "!" ;
           Console.WriteLine(msg.Enviar());
        }
    }
}
