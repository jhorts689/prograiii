package LeerInteface.java;

public class SUPERVISOR extends EMPLEADO{
    int sueldo,antiguedad;
    public SUPERVISOR(){

    }
    public void Leer(){
        Empleado.Leer();
        System.out.println("Ingrese el sueldo del Supervisor");
        sueldo = LEER.nextInt();
        System.out.println("Ingrese la antiguedad del Supervisor");
        antiguedad = LEER.nextInt();
    }
    public void Mostrar(){
        Empleado.Mostrar();
        System.out.println("sueldo: "+ sueldo);
        System.out.println("antiguedad: "+ antiguedad);
    }
}
