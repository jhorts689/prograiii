package DefensaTarea;

public class Profesor extends PERSONA{
    int cargarH;
    String Ciudad;
    int nroMaterias;
    String[] Materias;
    PERSONA persona = new PERSONA();

    public Profesor(){

    }

    public String getCiudad() {
        return Ciudad;
    }

    public void setCiudad(String ciudad) {
        Ciudad = ciudad;
    }

    public void Leer() {
        persona.Leer();
        System.out.println("Ingrese la cargarH del profesor");
        cargarH = LEER.nextInt();
        System.out.println("Ingrese la ciudad del profesor");
        Ciudad = LEER.next();
        System.out.println("Ingrese EL NRO DE MATERIAS del profesor");
        nroMaterias = LEER.nextInt();
        Materias = new String[nroMaterias];
        for(int i=0;i<nroMaterias;i++){
            System.out.println("Ingrese la materia "+(i+1)+" del Profesor");
            Materias[i] = LEER.next();
        }
    }
    public void Mostrar() {
        persona.Mostrar();
        System.out.println("cargarH: " + cargarH);
        System.out.println("Ciudad: " + Ciudad);
        for(int i=0;i<nroMaterias;i++){
            System.out.println("MATERIA "+(i+1)+": " +Materias[i]);
        }
    }

    public String[] getMaterias() {
        return Materias;
    }

    public void setMaterias(String[] materias) {
        Materias = materias;
    }

    public int getNroMaterias() {
        return nroMaterias;
    }

    public void setNroMaterias(int nroMaterias) {
        this.nroMaterias = nroMaterias;
    }
}
