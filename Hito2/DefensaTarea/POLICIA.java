package DefensaTarea;

public class POLICIA extends PERSONA{
    String Turno;
    int NroDestinos;
    String[] Destinos;
    PERSONA persona = new PERSONA();
    public POLICIA(){

    }

    public String[] getDestinos() {
        return Destinos;
    }

    public void setDestinos(String[] destinos) {
        Destinos = destinos;
    }

    public void Leer() {
        persona.Leer();
        System.out.println("Ingrese El turno del Policia");
        Turno = LEER.next();
        System.out.println("Ingrese el numero de destinos del Policia");
        NroDestinos = LEER.nextInt();
        Destinos = new String[NroDestinos];
        for(int i=0;i<NroDestinos;i++){
            System.out.println("Ingrese el destino "+(i+1)+" del Policia");
            Destinos[i] = LEER.next();
        }

    }
    public void Mostrar() {
        persona.Mostrar();
        System.out.println("Turno: " + Turno);
        for(int i=0;i<NroDestinos;i++){
            System.out.println("Destino "+(i+1)+": " +Destinos[i]);
        }
    }

}
