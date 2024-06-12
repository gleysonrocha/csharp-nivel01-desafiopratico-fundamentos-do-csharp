namespace DesafioFundamentosCSharp.Classes;
internal static class ManipulaStrings
{
    public static int ContarCaracteres(string texto)
    {
        int numCaracteres = 0;

        if (string.IsNullOrEmpty(texto) == false)
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                    continue;
                numCaracteres++;
            }

        return numCaracteres;
    }
}