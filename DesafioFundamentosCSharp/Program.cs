using System.Globalization;
using System.Text.RegularExpressions;
using DesafioFundamentosCSharp.Classes;

namespace DesafioFundamentosCSharp;

internal class Program
{
    static void Main(string[] args)
    {
        /*
            01) Crie um programa em que o usuário precisa digitar um nome e uma mensagem de 
            boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

            02) Crie um programa que concatene um nome e um sobrenome inseridos pelo 
            usuário e ao final exiba o nome completo.

            Obs.: Será utilizada a mesma classe Usuario para os exercícios acima.
        */
        Console.Clear();

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Usuario usuario = new Usuario(nome, sobrenome);

        string mensagem = usuario.ObterMensagemBoasVindas();
        string nomeCompleto = usuario.ConcatenarNomes();

        Console.WriteLine(mensagem);
        Console.WriteLine(nomeCompleto);
        
        Console.ReadKey();


        /* 
            03) Crie um programa com 2 valores do tipo double já declarados que retorne:
            - A soma entre esses dois números;
            - A subtração entre os dois números;
            - A multiplicação entre os dois números;
            - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
            - A média entre os dois números.
        */
        Console.Clear();

        Console.Write("Informe o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Calculadora.Valor1 = numero1;
        Calculadora.Valor2 = numero2;

        Console.WriteLine("Soma.........: {0}", Calculadora.GetAdicao());
        Console.WriteLine("Subtração....: {0}", Calculadora.GetSubtracao());
        Console.WriteLine("Multiplicação: {0}", Calculadora.GetMultiplicacao());
        Console.WriteLine("Divisão......: {0}", Calculadora.GetDivisao());
        Console.WriteLine("Média........: {0}", Calculadora.GetMedia());
        
        Console.ReadKey();


        /*
            04) Crie um programa em que o usuário digita uma ou mais palavras e é exibido a 
            quantidade de caracteres que a palavra inserida tem.
        */
        Console.Clear();
        
        Console.Write("Digite uma ou mais palavras: ");
        string texto = Console.ReadLine();

        int numCaracteres = ManipulaStrings.ContarCaracteres(texto);
        Console.WriteLine("O texto digitado possui {0} caracter(es).", numCaracteres);

        Console.ReadKey();


        /*
            05) Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
                - A placa deve ter 7 caracteres alfanuméricos;
                - Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
                - Os quatro últimos caracteres são números;
                Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
        */
        Console.Write("Informe o modelo do veículo: ");
        string modelo = Console.ReadLine();

        Console.Write("Informe a placa: ");
        string placa = Console.ReadLine();

        Veiculo carro = new Veiculo();
        carro.Modelo = modelo;
        carro.Placa = placa;

        bool placaValida = carro.ValidarPlaca();
        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");


        /*
            06) Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
                - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
                - Apenas a data no formato "01/03/2024".
                - Apenas a hora no formato de 24 horas.
                - A data com o mês por extenso.
        */
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Data Atual:");
        Console.WriteLine("Formato completo........: {0}", dataAtual.ToString("dddd, d/M/yyyy, h:mm:ss tt", new CultureInfo("pt-BR")));
        Console.WriteLine("Formato dd/mm/aaaa......: {0}", dataAtual.ToString("d/M/yyyy", new CultureInfo("pt-BR")));
        Console.WriteLine("Hora formato 24h........: {0}", dataAtual.ToString("HH:mm:ss", new CultureInfo("pt-BR")));
        Console.WriteLine("Data com mês por extenso: {0}", dataAtual.ToString("dd MMMM yyyy", new CultureInfo("pt-BR")));

        Console.ReadKey();
    }
}