public class Temporada {
    public int IdTemporada {set; get;}
    public int IdSerie { set;  get;}
    public int NumeroTemporada { set;  get;}
    public string TituloTemporada { set;  get;}
   
   // constructor
    public Temporada() {
        IdTemporada = 0;
        IdSerie = 0;
        NumeroTemporada = 0;
        TituloTemporada = "";
    }
    public Temporada(int idTemporada, int idSerie, int numeroTemporada, string tituloTemporada) {
        IdTemporada = idTemporada;
        IdSerie = idSerie;
        NumeroTemporada = numeroTemporada;
        TituloTemporada = tituloTemporada;
    }
}