using Microsoft.Data.SqlClient;
using Dapper;
namespace TP03Ahoracado.Models;

public class Ahorcado
{
private string _connectionString = @"Server=localhost; 
DataBase= Ahorcado;Integred Security= True;TrustServerCertificate=True;";
}

public List<Palabras> ObtenerPalabra(){

List<Palabras> palabras = new List<Palabras>();
using(SqlConnection connection = new SqlConnection(_connectionString))
{
    string query = "SELECT * FROM Palabras";
    palabras = connection.Query<Palabras>(query).ToList();
}
return palabras;

}