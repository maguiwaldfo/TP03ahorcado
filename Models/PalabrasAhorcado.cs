namespace TP03Ahoracado.Models;

public class PalabrasAhorcado
{
    public List<Palabras> palabras;

    public string ObtenerPalabra()
    {
        Random random = new Random();
        int p = random.Next(0, palabras.Count);
        return palabras[p];
    }
}