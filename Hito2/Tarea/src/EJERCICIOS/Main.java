package EJERCICIOS;

import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        int op;
        Ejercicios ejer = new Ejercicios();
        do{
            Scanner scanner = new Scanner(System.in);
            System.out.println("1.-Generar la serie fibonacci hasta un valor n leído por teclado ");
            System.out.println("2.-Mostrar 2 metodos de ordenacion de vectores. ");
            System.out.println("3.-Usando while y el método hasNext() de la clase Scanner, leer N cadenas haS... ");
            System.out.println("4.-Crear un array con 10 elementos enteros ");
            System.out.println("marque 0 para salir");
            System.out.println("Elija una opcion ");
            op = scanner.nextInt();
            switch (op){
                case 1:
                    ejer.ejercicio1();break;
                case 2: {
                    ejer.Ingresar();
                    int op1;
                    do {
                        System.out.println("1.-Metodo Burbuja");
                        System.out.println("2.-Metodo De Seleccion ");
                        System.out.println("marque 0 para salir");
                        System.out.println("Elija una opcion ");
                        op1 = scanner.nextInt();
                        switch (op1) {
                            case 1:
                                ejer.Burbuja();
                                break;
                            case 2:
                                ejer.seleccion();
                                break;

                            default:
                                break;
                        }
                    } while (op1 != 0);
                } break;
                case 3:
                    ejer.Ejercicio3();break;
                case 4:
                    ejer.ejercicio4();
                default:break;
            }


        }while (op != 0);
    }
}
