public class Animal
{
    // SOBRE CARGA
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som generico");
    }
    
    // SOBRE CARGA - sobre carregando
    public virtual void EmitirSom(string fala)
    {
        Console.WriteLine(fala);
    }
}

public class Cachorro : Animal
{
    // SOBRE ESCRITA
    // Pegando a funcao EmitirSom da classe Animal, e mudando o seu comportamento
    public override void EmitirSom()
    {
        Console.WriteLine("Au Auuu");
    }
}

public class Gato : Animal
{
    // Pegando a funcao EmitirSom da classe Animal, e mudando o seu comportamento
    public override void EmitirSom()
    {
        Console.WriteLine("Miauu");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.EmitirSom();

        Cachorro cachorro = new Cachorro();
        cachorro.EmitirSom("auu auuuu");
        
        Gato gato = new Gato();
        gato.EmitirSom();
    }
} 