package LeerInteface.java;

public class GERENTE extends EMPLEADO{
    int bono,sueldo,antiguedad;

    public GERENTE(){

    }
    public void Leer(){

        Empleado.Leer();
        System.out.println("Ingrese el bono del Gerente");
        bono = LEER.nextInt();
        System.out.println("Ingrese el sueldo del Gerente");
        sueldo = LEER.nextInt();
        System.out.println("Ingrese la antiguedad del Gerente");
        antiguedad = LEER.nextInt();
    }
    public void Mostrar(){
        Empleado.Mostrar();
        System.out.println("Bono: "+ bono);
        System.out.println("sueldo: "+ sueldo);
        System.out.println("antiguedad: "+ antiguedad);
    }
}
