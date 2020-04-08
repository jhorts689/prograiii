package DefensaTarea;

import javafx.util.converter.PercentageStringConverter;

public class PERSONA extends CIUDADANO{
    String EtapaCrecimiento;
    CIUDADANO ciudadano = new CIUDADANO();
    public PERSONA(){

    }
    public void Leer() {
        ciudadano.Leer();
        System.out.println("Ingrese la etapa de crecimiento de la persona");
        EtapaCrecimiento = LEER.next();
    }
    public void Mostrar() {
        ciudadano.Mostrar();
        System.out.println("Etapa de Crecimiento: " + EtapaCrecimiento);
    }
}
