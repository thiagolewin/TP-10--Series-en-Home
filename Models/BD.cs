using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Dapper;
public static class BD {
    private static string _connectionString = @"Server=localhost;DataBase=BDSeries;Trusted_Connection=True;";
    
    public static List<Serie> ListarSeries() {
        List<Serie> misSeries = new List<Serie>();
        using(SqlConnection db = new SqlConnection(_connectionString)) {
            string sql = "SELECT * FROM Series";
            misSeries = db.Query<Serie>(sql).ToList();
        }
        return misSeries;
    }
    
    public static List<Actor> ListarActores(int idSerie) {
        List<Actor> MisActores = new List<Actor>();
        using(SqlConnection db = new SqlConnection(_connectionString)) {
            string sql = "SELECT * FROM Actores WHERE IdSerie = " + idSerie;
            MisActores = db.Query<Actor>(sql).ToList();
        }
        return MisActores;
    }

     public static Serie Descripcion(int idSerie) {
        Serie descripcion = new Serie();
        using(SqlConnection db = new SqlConnection(_connectionString)) {
            string sql = "SELECT Sinopsis FROM Series WHERE IdSerie = " + idSerie;
            descripcion = db.QueryFirstOrDefault<Serie>(sql);
        }
        return descripcion;
    }

     public static List<Temporada> Temporada(int idSerie) {
        List<Temporada> temporada = new List<Temporada>();
        using(SqlConnection db = new SqlConnection(_connectionString)) {
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = " + idSerie;
            temporada = db.Query<Temporada>(sql).ToList();
        }
        return temporada;
    }
}