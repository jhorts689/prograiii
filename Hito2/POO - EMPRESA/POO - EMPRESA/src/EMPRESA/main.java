package EMPRESA;

import java.util.Scanner;

public class main {
    public static void main(String[] args) {
        Scanner leer = new Scanner(System.in);
        System.out.println("Ingrese el numero de empleados");
        int numero = leer.nextInt();
        String nombre = leer.nextLine();
        Empleado[] empleadosRRHH = new Empleado[2];
        for(int i=0; i<numero;i++){
            System.out.println("Ingrese el nombre del empleado");
            String Nombre = leer.next();
            System.out.println("Ingrese el CI del empleado");
            String ci = leer.next();
            System.out.println("Ingrese la edad del empleados");
            int Edad = leer.nextInt();
            Empleado empleado1 = new Empleado(Nombre,ci,Edad);
            empleadosRRHH[i] = empleado1;
        }

        //Empleado empleado2 = new Empleado("EMP1","5534534",34);
        //empleado1.imprimir();
//


        //empleadosRRHH[1] = empleado2;
        Area area1 = new Area("RRHH",empleadosRRHH);
        //area1.Imprimir();
        Area[] areadeempresa = new Area[1];
        areadeempresa[0] = area1;
        empresa empresa1 = new empresa(" unifranz",areadeempresa);
        empresa1.IMPRIMIR();

    }
}
