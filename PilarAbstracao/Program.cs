public abstract class FormaGeometrica
{
    public abstract decimal Area;
}

public class Quadrado : FormaGeometrica
{
    // para criar um objeto da classe Quadrado - eu preciso passar certos valores
    public Quadrado(decimal valorLargura, decimal valorAltura)
    {
        largura = valorLargura;
        altura = valorAltura;
    }
    public decimal largura;
    public decimal altura;

    public override decimal Area => (largura * altura);
}

// Configuaração Padrão
class Program
{
    static void Main()
    {
        // UMA CLASSE ABSTRATA NUNCA GERA UM OBJETO
        // FormaGeometrica forma = new FormaGeometrica();

        Quadrado quadrado = Quadrado(15, 15);
        // quadrado.largura = 15;
        // quadrado.altura = 15;
        quadrado.Area = quadrado.largura * quadrado.altura;
    }
}