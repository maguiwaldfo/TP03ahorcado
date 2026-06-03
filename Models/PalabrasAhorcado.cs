namespace TP03Ahoracado.Models;

public class PalabrasAhorcado
{
    private List<string> palabras;

    public PalabrasAhorcado()
    {
        palabras = new List<string>
        {
            "PROGRAMACIÓN",
            "COMPUTADORA",
            "ALGORITMO",
            "DATABASE",
            "SOFTWARE",
            "INTERFAZ",
            "COMPILADOR",
            "VARIABLE",
            "MEMORIA",
            "SERVIDOR"
        };
    }

    public string ObtenerPalabra()
    {
        Random random = new Random();
        int p = random.Next(palabras.Count);
        return palabras[p];
    }
}