package Introduccion;
import java.util.Scanner;
public class Ejercicios {
    public Scanner leer;
    public Ejercicios(){
        leer = new Scanner(System.in);
    }
    public void SerieNaturales(int n){
        for(int i = 0; i<10;i++){
             System.out.println(i);
        }
    }
    public void compra2Cadenas(String cad1, String cad2){
        if (cad1.equals(cad2)){
            System.out.println("Cadenas iguales");
        }
        else{
            System.out.println("Cadenas Distintas");
        }
    }
    public void GenerarS(int limit){

        for (int i = 1; i<limit;i++){
            if (i%2!=0){
                System.out.printf(" %d ",i+1);
            }
            else{
                System.out.printf(" %d ",i-1);
            }

        }
    }
}
