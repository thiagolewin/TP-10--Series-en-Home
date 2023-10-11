public class Serie {
    public int IdSerie {set; get;}
    public string Nombre { set;  get;}
    public int AñoInicio { set;  get;}
    public string Sinopsis { set;  get;}
    public string ImagenSerie { set;  get;}
   
   // constructor
    public Serie() {
        Nombre = "";
        AñoInicio = 0;
        Sinopsis = "";
        ImagenSerie = "";
    }
    public Serie(string nombre, int añoInicio, string sinopsis, string imagenSerie) {
        Nombre = nombre;
        AñoInicio = añoInicio;
        Sinopsis = sinopsis;
        ImagenSerie = imagenSerie;
    }
}