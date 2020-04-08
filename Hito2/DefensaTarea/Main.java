package DefensaTarea;

public class Main {
    public static void main(String[] args) {
        POLICIA policia1 =new POLICIA();
        POLICIA policia2 =new POLICIA();
        Profesor profesor1 = new Profesor();
        Profesor profesor2 = new Profesor();
        policia1.Leer();
        policia1.Mostrar();
        policia2.Leer();
        policia2.Mostrar();
        profesor1.Leer();
        profesor1.Mostrar();
        profesor2.Leer();
        profesor2.Mostrar();
        int cont =0;
        for(int i = 0; i < profesor1.getNroMaterias(); i++){
            for(int j = 0; j < profesor1.getNroMaterias(); j++){
                if(profesor1.getMaterias()[i] == profesor2.getMaterias()[j]){
                    cont++;
                }
            }
        }
        boolean verdad = false;
        System.out.println("la cantidad de materias repetidas son "+ cont);
        for(int j = 0; j < policia1.getDestinos().length; j++){
            if(profesor1.getCiudad() == policia1.getDestinos()[j]){
                System.out.println("la ciudad del profesor 1 tiene el mismo destino que el policia 1 ");
                j = policia1.getDestinos().length;
            }
            if(profesor2.getCiudad() == policia1.getDestinos()[j]){
                System.out.println("la ciudad del profesor 2 tiene el mismo destino que el policia 1 ");
                j = policia1.getDestinos().length;
            }
        }
        for(int j = 0; j < policia2.getDestinos().length; j++){
            if(profesor1.getCiudad() == policia2.getDestinos()[j]){
                System.out.println("la ciudad del profesor 1 tiene el mismo destino que el policia 2 ");
                j = policia1.getDestinos().length;
            }
            if(profesor2.getCiudad() == policia2.getDestinos()[j]){
                System.out.println("la ciudad del profesor 2 tiene el mismo destino que el policia 2 ");
                j = policia1.getDestinos().length;
            }
        }
    }
}
