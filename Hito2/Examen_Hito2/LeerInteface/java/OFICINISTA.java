package LeerInteface.java;

import org.omg.CORBA.PUBLIC_MEMBER;

import java.util.Spliterator;

public class OFICINISTA extends EMPLEADO{
        String codArea;
        int SueldoBasico;
        OFICINISTA oficinista = new OFICINISTA();
        public OFICINISTA(){

        }
        public void Leer(){
                Empleado.Leer();
                System.out.println("Ingrese el Codigo de Area del Oficinista");
                codArea = LEER.next();
                System.out.println("Ingrese el sueldo basico del Oficinista");
                SueldoBasico = LEER.nextInt();
        }
        public void Mostrar(){
                Empleado.Mostrar();
                System.out.println("Cod. de Area: "+ codArea);
                System.out.println("Sueldo Basico: "+ SueldoBasico);
        }
}
