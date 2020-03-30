package EJEMPLOS;

public class Estudiante extends Persona{
    int NumMaterias;
    String NombreDeSuUniversidad;
    int MensualidadDpago;
    int CIdeEstudiante;
    public Estudiante( String Nombre,String Apellido,int Edad,int CI ,int NumMaterias,
                       String NombreDeSuUniversidad, int MensualidadDpago, int CIdeEstudiante) {
        super(Nombre, Apellido, Edad, CI);
        this.NumMaterias = NumMaterias;
        this.NombreDeSuUniversidad = NombreDeSuUniversidad;
        this.MensualidadDpago =MensualidadDpago;
        this.CIdeEstudiante = CIdeEstudiante;
    }
}
