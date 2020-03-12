package EMPRESA;

public class empresa {
    private String nombre;
    private Area[] areas;
    public empresa(String nombre1, Area[] areas1){
        this.areas = areas1;
        this.nombre = nombre1;
    }
    public void setNombre (String Nombre) {
        this.nombre = Nombre;
    }
    public String getNombre(){
        return this.nombre;
    }
    public void IMPRIMIR(){
        System.out.println("Nombre de Empresa:" + this.nombre);
        for (int i = 0; i<this.areas.length;i++ ){
            this.areas[i].Imprimir();
        }
    }
}
