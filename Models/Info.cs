public class Info {
    public string Informacion { set;  get;}
   
   // constructor
    public Info() {
        Informacion = "";
    }
    public Info(string informacion) {
        Informacion = informacion;
    }
}