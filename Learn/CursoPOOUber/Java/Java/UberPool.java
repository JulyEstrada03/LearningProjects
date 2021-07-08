package Java;

class UberPool extends Car
{
    String brand;
    String model;

    public UberPool(String license, Account driver, String brand, String model)
    {
        super(license,driver); // Referencia a la clase padre.
        this.brand = brand;
        this.model = model;
    }
}