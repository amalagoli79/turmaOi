using Back_End_ER02.Interfaces;

namespace Back_End_ER02.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cmpj { get; set; }
        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}