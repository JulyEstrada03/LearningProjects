package Java;

public class Car {
    private Integer id;
    private String license;
    private Account driver;
    private Integer passenger;

    public Car(String license, Account driver)
    {
        this.license = license;
        this.driver = driver;
        passenger = 4;
    }

    public Integer getPassenger()
    {
        return passenger;
    }

    public void serPassenger(Integer numPassengers){
        if(numPassengers < 4)
        {
            System.out.println("Número de pasajeros no es valido. solo 4 pasajeros");
        }
        else
        {
            passenger = numPassengers;
        }
    }   

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getLicense() {
        return license;
    }

    public void setLicense(String license) {
        this.license = license;
    }

    public Account getDriver() {
        return driver;
    }

    public void setDriver(Account driver) {
        this.driver = driver;
    }

    void printCarInformation()
    {
        System.out.println("Car license: " + this.license);   
        System.out.println("Driver: " + this.driver.name); 
    }
}


