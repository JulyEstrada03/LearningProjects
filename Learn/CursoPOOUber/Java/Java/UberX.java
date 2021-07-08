package Java;

class UberX extends Car
{
    String brand;
    String model;

    public UberX(String license, Account driver, String brand, String model)
    {
        super(license,driver); // Referencia a la clase padre.
        this.brand = brand;
        this.model = model;
    }

    @Override
    void printCarInformation() {
        super.printCarInformation();
        System.out.println("Marca: " + brand);
        System.out.println("Modelo: " + model);
    } 
}