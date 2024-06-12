namespace DesafioFundamentosCSharp.Classes;
public static class Calculadora
{
    public static double Valor1 { get; set; }
    public static double Valor2 { get; set; }

    public static double GetAdicao() => Valor1 + Valor2;
    public static double GetSubtracao() => Valor1 - Valor2;
    public static double GetMultiplicacao() => Valor1 * Valor2;
    public static double GetMedia() => (Valor1 + Valor2) / 2;
    public static double GetDivisao()
    {
        if (Valor2 != 0)
            return Valor1 / Valor2;
        else
            return 0;
    }
}