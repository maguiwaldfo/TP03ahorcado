namespace TP03Ahoracado.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado()
    {
        palabras = new List<string>
        {
            "PROGRAMACION",
            "COMPUTADORA",
            "ALGORITMO",
            "PROYECTOR",
            "SOFTWARE",
            "INTERFAZ",
            "PROCESADOR",
            "INFORMATICA",
            "MEMORIA",
            "GABINETE"
        };
    }

    public string ObtenerPalabra()
    {
        Random random = new Random();
        int p = random.Next(palabras.Count);
        return palabras[p];
    }
}