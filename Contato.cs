namespace Wpp_Console
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set;}
      
        public Contato(string _nome, string _telefone){
            this.Nome  =  _nome;
            this.Telefone  =  _telefone;
        }
    }
}