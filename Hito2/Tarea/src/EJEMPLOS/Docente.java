package EJEMPLOS;

public class Docente extends Persona{
    int sueldo;
    int CIdeDocente;

    public Docente( String Nombre,String Apellido,int Edad,int CI ,int sueldo,int CIdeDocente) {
        super(Nombre,Apellido,Edad,CI);
        this.sueldo = sueldo;
        this.CIdeDocente =CIdeDocente;
    }
}
