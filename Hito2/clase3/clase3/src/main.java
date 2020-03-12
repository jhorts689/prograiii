import Introduccion.Ejercicios;

import java.util.Scanner;
public class main {

    public static void main(String[] args) {
        Scanner leer = new Scanner(System.in);
//        int contador =0;
//        while (leer.hasNextInt())
//        {
//            System.out.println("ingrese un numero");
//
//            int credito_limite=leer.nextInt();
//            if (credito_limite > 50000) {
//                System.out.println("es platino");
//            }
//            if (credito_limite>= 10000 && credito_limite <= 50000) {
//                System.out.println("es gold");
//            }
//            if (credito_limite < 10000) {
//                System.out.println("Es SILVER");
//            }
//        }
        Ejercicios ejercicios = new Ejercicios();
//        ejercicios.SerieNaturales(11);
//        ejercicios.compra2Cadenas("HOLA","hola");
        ejercicios.GenerarS(11);
        //CREAR UN WHILE
        //LEEROPTION = COMPARA;


    }
}
