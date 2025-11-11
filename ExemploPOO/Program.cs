
public class Calculadora
{
    // Propriedade (Atributos)
    public float numero01;
    public float numero02;

    // Métodos (Comportamentos)
    public float Somar()
    {
        Console.WriteLine(numero01 + numero02);
        return numero01 + numero02;
    }

    public float Subtrair()
    {
        Console.WriteLine(numero01 - numero02);
        return numero01 - numero02;
    }
    public float Dividir()
    {
        //Math.Round - arredonda as casas decimais para 2 casas
        Console.WriteLine(Math.Round(numero01 / numero02) );
        return numero01 / numero02;
    }
    public float Multiplicar()
    {
        Console.WriteLine(numero01 * numero02);
        return numero01 * numero02;
    }
}

// configurar o ambiente de execução
class Program
{
    static void Main()
    {
        /* Iniciando o uso da classe para criar objetos */

        // Instanciar (criar) 
        // Calculadora calculadora = new Calculadora();

        // Atribuindo os Valores das propriedades do objeto da calculadora
        // calculadora.numero01 = 10;
        // calculadora.numero02 = 11;

        // Executando os metodos contidos na classe calculadora
        // calculadora.Somar();
        // calculadora.Subtrair();
        // calculadora.dividir();
        // calculadora.multiplicar();


        // Instanciar (criar) uma variável do padrão CLASSE CALCULADORA
        Calculadora calculadora = new();

        Console.WriteLine("Bem-Vindo(a) ao sistema de Calculadora");
        Console.WriteLine();

        Console.WriteLine("Digite o Primeiro número");
        calculadora.numero01 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Segundo número");
        calculadora.numero02 = float.Parse(Console.ReadLine());

        Console.WriteLine(@"Escolha a sua operação Matemática:
            1 - Somar
            2 - Subtrair
            3 - Dividir
            4 - Multiplicar                    
        ");
        int opcaoCalculadora = int.Parse(Console.ReadLine());

        switch (opcaoCalculadora)
        {
            case 1:
                calculadora.Somar();
                break;
            case 2:
                calculadora.Subtrair();
                break;
            case 3:
                calculadora.Dividir();
                break;
            case 4:
                calculadora.Subtrair();
                break;
        }
    }
}
