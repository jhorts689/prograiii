package VECTORES;

import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner leer = new Scanner(System.in);

        vectores vector = new vectores();
        vector.Insertar_Datos();
        vector.burbuja();
    }
}
