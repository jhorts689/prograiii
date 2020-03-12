package EMPRESA;

public class Area {
    private String nombre;
    private Empleado[] empleados;
    public Area(String nombre1, Empleado[] empleados1){
        this.nombre = nombre1;
        this.empleados = empleados1;
    }
    public void setEmpleados(Empleado[] empleados){
        this.empleados = empleados;
    }

    public Empleado[] getEmpleados() {
        return this.empleados;
    }
    public void Imprimir(){

        System.out.println("Nombre de Area: " + this.nombre);
        for (int i = 0; i<this.empleados.length;i++ ){
            this.empleados[i].imprimir();
        }
    }
}
