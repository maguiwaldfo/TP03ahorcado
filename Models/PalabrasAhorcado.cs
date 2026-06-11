namespace TP03Ahoracado.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado()
    {
        palabras = new List<string>
        {
            "TATEMCRAE",
            "CAZUALES",
            "WANDAGATE",
            "MILANESA",
            "COCACOLA",
            "ARGENTINA",
            "MIRTALEGRAND",
            "LIONELMESSI",
            "SNAPCHAT",
            "INSTAGRAM"
        };
    }

    public string ObtenerPalabra()
    {
        Random random = new Random();
        int p = random.Next(0, palabras.Count);
        return palabras[p];
    }
}