namespace TrabalhoRevisao.entidades
{ 
public class Veiculo
{
    public string idV;
    public string placa;
    public string numeroMotor;
    private string chassi;
    public string renavam;
    public string anoModelo;
    public string modelo;
    public string marca;
    public string cidade;
    public string situacao;
    public string cor;
    public Proprietario proprietario;

    public void SetChassi(string c)
    {
        if (c.Length == 17)
        {
            chassi = c;
        }
        else
        {
            throw new Exception("Número do chassi fora dos padrões exigidos");
        }
    }
    public string GetChassi()
    {
        return chassi;
    }


}
}

