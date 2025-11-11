// See https://aka.ms/new-Console-template for more information
Console.WriteLine("Hello, World!");

// CamalCase = nomeVariavel
// PascalCase = NomeVariavel
//snack_case = nome_variavel

//tipoDeDado nomeVariavel = valorDaVariavel
int numeroInteiro = 1;

double preco = 5.60D;

float Altura = 1.80f;

bool boleanos = true;

char character = 'A';

string nome = "Marcelo Santiago de Oliveira";

Console.WriteLine(nome);

/*----------------------------------------*/

Console.WriteLine("Soma : " + (1 + 2));
Console.WriteLine("Subtração : " + (1 - 2));
Console.WriteLine("Divisão : " + (1 / 2));
Console.WriteLine("Multiplicação : " + (1 * 2));
/*----------------------------------------*/


// = atribuição
//== comparação
//=== comparar valor e tipo

// Operador de igualdade (==)
// Comparar se valores são iguais
Console.WriteLine(5 == 5);

// Operador de diferença (!=)
// Comparar se valores não são iguais
Console.WriteLine(5 != 5);

// Operador de maior (>)
// Comparar se um valor é maior do que o outro
Console.WriteLine(8 > 4);

// Operador de menor que (<)
// Comparar se um valor é menor que o outro
Console.WriteLine(4 < 8);

// Operador de maior ou igual (>=)
// comparar se um valor é maior ou igual
Console.WriteLine(8 >= 4);

// Operador de menor ou igual (<=)
// comparar se um valor é maior ou igual
Console.WriteLine(4 <= 8);


/*----------------------------------------*/

/* OPERADORES LÓGICOS */
// && (e) -- || (ou)
// ! (não/negativa)

Console.WriteLine(5 == 5 && 8 == 8); // true && true (true)

Console.WriteLine(5 == 5 && 18 == 8); // true && false (false)

Console.WriteLine(5 == 15 && 18 == 8); // false && false (false)


Console.WriteLine(2 == 2 || 3 == 3); // true || true (true)

Console.WriteLine(2 == 4 || 3 == 3); // false || true (true)

Console.WriteLine(2 == 4 || 3 == 9); // false || false (false)


Console.WriteLine(!true == true);

Console.WriteLine(!(2 == 2 || 3 == 3));

/*----------------------------------------*/

bool noite = true;

//se naose
if(noite){
    Console.WriteLine("Agora é noite");
}
else{
    Console.WriteLine("Agora é de dia");
}

//if ternario
var condicao = (noite) ? "Agora é de noite!" : "Agora é de dia";

var idade = 20;

if (idade < 18)
{
    Console.WriteLine("Pessoa menor de idade");
}
else if (idade >= 18 && idade < 21)
{
    Console.WriteLine("Maior de idade mas não de maioridade penal");
}
else
{
    Console.WriteLine("Maior de idade legal");
}

int diaSemana = 1;

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    case 4:
        Console.WriteLine("Quarta-feira");
        break;
    case 5:
        Console.WriteLine("Quinta-feira");
        break;
    case 6:
        Console.WriteLine("Sexta-feira");
        break;
    case 7:
        Console.WriteLine("Sabado-feira");
        break;
    default:
        Console.WriteLine("Dia da semana invalido");
        break;
}

/*----------------------------------------*/

/* Enquanto == While -> Laço de repetição */
int numero = 1;

while (numero < 10)
{
    Console.WriteLine(numero);
    numero = numero + 1; //numero++
}

int numero02 = 1;

do{
    Console.WriteLine(numero02);
    numero02 = numero02 + 1; // numero++
}while (numero02 < 10);

/*for(valor inicial; condição; processamento;)*/
for (int valor = 0; valor < 10; valor++)
{
    Console.WriteLine(valor);
}

/*----------------------------------------*/

static string InformarNome(string nome)
{
    return (nome);
}

Console.WriteLine(InformarNome("Marcelo Santiago"));

/* FUNÇÃO SEM RETORNO DE NADA */
void somarValores(int numero01, int numero02)
{
    Console.WriteLine(numero01 + numero02);
}
somarValores(10, 20);

/*----------------------------------------*/

int[] arrayNumeros = new int[3];

arrayNumeros[0] = 1;
arrayNumeros[1] = 2;
arrayNumeros[2] = 3;

string[] nomes = { "Marcelo", "Ana", "Mari" };


/*----------------------------------------*/

int[,] matrizNumeros = new int[3, 3];

matrizNumeros[0, 0] = 1;
matrizNumeros[0, 1] = 2;
matrizNumeros[0, 2] = 3;

matrizNumeros[1, 0] = 4;
matrizNumeros[1, 1] = 5;
matrizNumeros[1, 2] = 6;

matrizNumeros[2, 0] = 7;
matrizNumeros[2, 1] = 8;
matrizNumeros[2, 2] = 9;

