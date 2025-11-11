public class Veiculo
{
    public string Marca;

    public void LigarMotor()
    {
        Console.WriteLine("Veiculo ligado!")
    }
}

// Classe carro vai herdar os comportamentos e propriedades de veiculo
public class Carro : Veiculo
{
    public int quantidadePortas;
}

public class Moto : Veiculo
{
    public int cilindradas;
}

/* Configurações do projeto */
class Program
{
    static void Main()
    {
        //Criando uma instancia da classe Carro
        Carro meuCarro = new Carro();

        meuCarro.quantidadePortas = 2;
        meuCarro.Marca = "Honda Civic";
        meuCarro.LigarMotor();

        Moto minhaMoto = new Moto();

        minhaMoto.cilindradas = 150;
        minhaMoto.Marca = "Harley";
        minhaMoto.LigarMotor();
    } 
}