public class Actor {
    public int IdActor {set; get;}
    public int IdSerie { set;  get;}
    public string Nombre { set;  get;}
   
   // constructor
    public Actor() {
        IdActor = 0;
        IdSerie = 0;
        Nombre = "";
    }
    public Actor(int idActor, int idSerie, string nombre) {
        IdActor = idActor;
        IdSerie = idSerie;
        Nombre = nombre;
    }
}