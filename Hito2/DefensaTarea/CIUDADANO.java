package DefensaTarea;

public class CIUDADANO implements LeerInterface {
    String PrimerNombre;
    String PrimerApellido;
    int CINumber;
    String CIExt;
    int Edad;
    public CIUDADANO(){

    }
    public void Leer() {
        System.out.println("Ingrese el nombre del Ciudadano");
        PrimerNombre = LEER.next();
        System.out.println("Ingrese el apellido del Ciudadano");
        PrimerApellido = LEER.next();
        System.out.println("Ingrese el CI del Ciudadano");
        CINumber = LEER.nextInt();
        System.out.println("Ingrese el CI de extencion del Ciudadano");
        CIExt = LEER.next();
        System.out.println("Ingrese la edad del Ciudadano");
        Edad = LEER.nextInt();
    }
    public void Mostrar(){
        System.out.println("Nombre: "+ PrimerNombre);
        System.out.println("Apellido: "+ PrimerApellido);
        System.out.println("CI: "+ CINumber);
        System.out.println("CIExtencion: "+ CIExt);
        System.out.println("Edad: "+ Edad);
    }
}
