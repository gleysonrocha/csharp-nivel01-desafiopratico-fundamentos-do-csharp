using System.Text.RegularExpressions;

namespace DesafioFundamentosCSharp.Classes;
internal class Veiculo
{
    public string Modelo { get; set; }
    public string Placa { get; set; }

    public bool ValidarPlaca()
    {
        Placa = Placa.Trim();

        if (Placa.Length != 7)
            return false;

        string parteInicial = Placa.Substring(0, 3);
        string parteFinal = Placa.Substring(3, 4);

        return Regex.IsMatch(parteInicial, @"^[a-zA-Z]+") && Regex.IsMatch(parteFinal, @"^[0-9]+$");
    }
}