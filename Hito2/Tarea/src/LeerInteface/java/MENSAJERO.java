package LeerInteface.java;

public class MENSAJERO extends OFICINISTA{
    String turno;
    public MENSAJERO(){

    }
    public void Leer(){
        oficinista.Leer();
        System.out.println("Ingrese el turno en el que trabaja el Oficinista");
        turno = LEER.next();
    }
    public void Mostrar(){
        oficinista.Mostrar();
        System.out.println("Turno: "+ turno);
    }
}
