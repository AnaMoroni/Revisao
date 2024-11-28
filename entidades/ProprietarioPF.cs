namespace TrabalhoRevisao.entidades
{
    public class ProprietarioPF : Proprietario
    {
        public string idPF;
        private string cpf;
        public string rg;
        public string dataNasc;
        public string sexo;

        public void SetCpf(string c)
        {
            if (c.Length == 11)
            {
                c = c.Replace(".", "");
                c = c.Replace("-", "");
                cpf = c;
            }
            else
            {
                throw new Exception("Número do cpf fora dos padrões exigidos");
            }
        }
        public string GetCpf()
        {
            return cpf;
        }
    }
}
