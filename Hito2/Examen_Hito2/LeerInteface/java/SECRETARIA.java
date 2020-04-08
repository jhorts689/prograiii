package LeerInteface.java;

public class SECRETARIA extends OFICINISTA {
    String NombreArea;
    public SECRETARIA(){

    }
    public void Leer(){
        oficinista.Leer();
        System.out.println("Ingrese el Nombre de Area del Oficinista");
        NombreArea = LEER.next();
    }
    public void Mostrar(){
        oficinista.Mostrar();
        System.out.println("Nombre Del Area: "+ NombreArea);
    }
}
