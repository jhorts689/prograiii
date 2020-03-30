package EJERCICIOS;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

public class Ejercicios {
    int[] vector;
    int tam;

    public Ejercicios(){

    }
    public void ejercicio1(){
        Scanner scanner = new Scanner(System.in);
        System.out.println("Ingrese los n valores que desee mostrar de la serie fibonacci");
        int n = scanner.nextInt();
        int a=0,b=1,c=0;
        for(int i = 0;i<n;i++) {
            System.out.printf("%d, ", a);
            c = a;
            a = a + b;
            b = c;
        }
        System.out.println();
    }
    public void Ingresar(){
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingrese el tamaño del vector");
        tam = sc.nextInt();
        vector = new int[tam];
        for (int i=0; i< tam;i++){
            System.out.println("Ingrese el valor en la pocicion " + (i+1)+" del vector");
            vector[i]= sc.nextInt();
        }
        System.out.println();
    }
    public void Burbuja(){

       int aux=0;
       for(int i=0;i<=tam;i++){
           for(int j=0;j<tam-1;j++){
               if(vector[j]>vector[j+1]){
                   aux=vector[j];
                   vector[j]=vector[j+1];
                   vector[j+1]=aux;
               }
           }
       }
       for(int i=0;i<tam;i++){
           System.out.printf("%d",vector[i]);
       }
       System.out.println();
    }
    public void seleccion(){
        int aux=0,minimo=0;
        for(int i=0;i<tam;i++){
            minimo=i;
            for(int j=i+1;j<tam;j++){
                if(vector[minimo] > vector[j]) {
                    aux = vector[minimo];
                    vector[i] = vector[j];
                    vector[j] = aux;
                }
            }
        }

        for(int i=0;i<tam;i++){
            System.out.printf("%d",vector[i]);
        }
        System.out.println();
    }
    public void Ejercicio3(){
        Scanner sc = new Scanner(System.in);
        System.out.println("Ingrese los n elementos de la cadena");
        int tam = sc.nextInt();
        String[] cadena = new  String[tam];
        ArrayList<String> al = new ArrayList<String>();
        for (int i=0; i<tam;i++){
            al.add(sc.next());
        }
        Iterator<String> it = al.iterator();
        while(it.hasNext() )
            System.out.println(it.next());
    }
    public void ejercicio4(){
        int[] vector = new int[10];
        int cont=0;
        for(int i=0; i<10; i++){
            Scanner sc = new Scanner(System.in);
            System.out.println("Ingrese el valor en la pocicion " + (i+1)+" del vector");
            vector[i] = sc.nextInt();
            if ((vector[i]%2==0)){
                cont++;
            }
        }
        System.out.println("la cantidad de numeros pares del arrays es " + (cont));
    }
}
