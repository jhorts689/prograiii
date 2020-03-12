package VECTORES;
import java.util.Scanner;

public class vectores implements Ordenacion {
    int tamaño;
    int[] vector = new int[4];
    public vectores(){
    }

    public void Insertar_Datos(){

        Scanner leer = new Scanner(System.in);
        System.out.println("Ingrese el tamaño del vector");
        int tamaño = leer.nextInt();
        for (int i=0;i<tamaño;i++){
            System.out.println("Inserte el valor numero "+(i+1));
            vector[i] = leer.nextInt();
        }
    }
    public void burbuja(){
        int aux=0;
        for (int j=0;j<vector.length;j++) {
            for (int i = j + 1; i < vector.length; i++) {
                if (vector[j] > vector[i]) {
                    aux = vector[j];
                    vector[j] = vector[i];
                    vector[i] = aux;
                }
            }
        }
        for (int i=0;i<vector.length;i++){
            System.out.println(vector[i]);
        }
    }
    public void Insercion(){
        int p, j;
        int aux;
        for (p = 1; p < vector.length; p++){
            aux = vector[p];
            j = p - 1;
            while ((j >= 0) && (aux < vector[j])){
                vector[j + 1] = vector[j];
                j--;
            }
            vector[j + 1] = aux;
        }
        for (int i=0;i<tamaño;i++){
            System.out.println(vector[i]);
        }
    }
}
