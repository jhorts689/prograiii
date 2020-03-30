package LeerInteface.java;

import org.omg.CORBA.PUBLIC_MEMBER;

public class EMPLEADO implements LeerInteface{
    String PrimerNombre;
    String PrimerApellido;
    int CINumero;
    String CIExtencion;
    public EMPLEADO(){
    }
//    public EMPLEADO(String PrimerNombre,String PrimerApellido,int CINumero,String CIExtencion ){
//        this.PrimerApellido = PrimerApellido;
//        this.PrimerNombre = PrimerNombre;
//        this.CINumero = CINumero;
//        this.CIExtencion = CIExtencion;
//    }
    public void Leer() {
        System.out.println("Ingrese el nombre del empleado");
        PrimerNombre = LEER.next();
        System.out.println("Ingrese el apellido del empleado");
        PrimerApellido = LEER.next();
        System.out.println("Ingrese el CI del empleado");
        CINumero = LEER.nextInt();
        System.out.println("Ingrese el CI de extencion del empleado");
        CIExtencion = LEER.next();
    }
    public void Mostrar(){
        System.out.println("Nombre: "+ PrimerNombre);
        System.out.println("Apellido: "+ PrimerApellido);
        System.out.println("CI: "+ CINumero);
        System.out.println("CIExtencion: "+ CIExtencion);
    }
}
